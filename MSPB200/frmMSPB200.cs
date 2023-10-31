using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using log4net;
using MSPB200.Common;
using MSPB200.dao;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace MSPB200.MSPB200
{
    public partial class frmMSPB200 : Form
    {
        // <summary>
        // ログ
        // </summary>
        //log4net使用宣言
        private static readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string _prmName = "プレドラ";
        private static readonly string _drName = "ドラレコ";
        private static readonly string _sdrName = "プレドラ切替";
        private static readonly string _companyCode = "1";
        private static int registDataCnt = 0;
        daofrmMSPB200 dao = null;
        DataTable dt = null;
        DataTable dtCheckBoxList = null;
        DataTable copyDT = null;

        
        public frmMSPB200()
        {
            _logger.Info("私物登録：開始");

            InitializeComponent();            

            txtStaffName.ImeMode = (ImeMode)4;
            txtETC.ImeMode = (ImeMode)4;

            // ロード時にフォーカスを設定する
            this.ActiveControl = this.txtStaffName;

            //Form画面の背景色&ラベルの文字色を初期設定
            var formInit = new frmBackColorChange();
            formInit.Set_FormInit(this);

        }

        #region イベント
        #region 私物登録Form_Load
        private void MSPB200_Load(object sender, EventArgs e)
        {
            // 登録日に本日の日付セット
            txtRegistDate.Text = System.DateTime.Now.ToString("yyyyMMdd");

            // 私物内容を私物テーブルより取得してセット
            checkList_Binding();
        }

        #endregion

        #region 終了ボタン押下
        /// <summary>
        /// 終了
        /// </summary>
        /// <remarks></remarks>
        private void End_Click(object sender, EventArgs e)
        {
            _logger.Debug("私物登録：終了ボタン押下");
            _logger.Info("私物登録：終了");
            Application.Exit();            
        }
        #endregion

        #region 登録ボタン押下
        /// <summary>
        /// 登録
        /// </summary>
        /// <remarks></remarks>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 管理番号入力チェック
            if (txtControlNo.Text == "")
            {
                new clsMessageBox().MessageBoxOKOnly("登録データがありません。", "警告", MessageBoxIcon.Warning);                
                txtControlNo.Focus();
                return;
            }
            // 私物内容のチェックリストのいずれかもチェックしていない場合
            if(checkBoxPB1.Checked == false && checkBoxPB2.Checked == false && checkBoxPB3.Checked == false && checkBoxPB4.Checked == false && checkBoxPB5.Checked == false &&
               checkBoxPB6.Checked == false && checkBoxPB7.Checked == false && checkBoxPB8.Checked == false && checkBoxPB9.Checked == false && checkBoxPB10.Checked == false &&
               checkBoxETC.Checked == false)
            {
                new clsMessageBox().MessageBoxOKOnly("私物内容をチェックして下さい。", "警告", MessageBoxIcon.Warning);                
                return;
            }
            // 私物内容のチェックリストのその他のチェックはしているが内容がない場合
            if (checkBoxETC.Checked == true && txtETC.Text == "")
            {
                new clsMessageBox().MessageBoxOKOnly("その他　内容を入力してください。", "警告", MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = new clsMessageBox().MessageBoxYesNo("登録します、よろしいですか？", "私物登録", MessageBoxIcon.Information);
            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                // チェックされたcheckboxの私物内容を結合
                var joinList = joinCheckedLabel();
                
                try
                {
                    _logger.Info("エスカレテーブル登録処理：開始");

                    // エスカレテーブルよりIDのMAXを取得
                    DataTable dtMaxId = dao.Select_T_ESCALATION_MAX_ID();

                    // エスカレテーブルデータ0件考慮
                    decimal maxId = 0;

                    if (!string.IsNullOrEmpty(dtMaxId.Rows[0]["MAX_ID"].ToString()))
                    {
                        maxId = decimal.Parse(dtMaxId.Rows[0]["MAX_ID"].ToString());
                    }
                    
                    // エスカレテーブルにデータ登録
                    dao.Insert_T_ESCALATION(maxId + 1, joinList, copyDT);

                }
                catch (Exception ex)
                {
                    _logger.Info("エスカレテーブルの登録処理でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                    new clsMessageBox().MessageBoxOKOnly("エスカレテーブルの登録処理でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    _logger.Info("エスカレテーブル登録処理：終了");
                }

                // 登録件数カウント
                registDataCnt++;
                // 登録件数カウントを画面にセット
                lblRegistCnt.Text = registDataCnt.ToString();
                // 入力項目有効化
                inputMenuDefualtDisplay();

                return;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region 登録日入力制限（数値のみ）＆日付形式チェック

        private void keyPressRegistDateCheck(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputRegistDateCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!DateTime.TryParseExact(txtRegistDate.Text, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out var d))
                {
                    new clsMessageBox().MessageBoxOKOnly("登録日の形式が異なります、日付を確認してください。", "警告", MessageBoxIcon.Warning);
                    txtRegistDate.Focus();
                    return;
                }
            }
        }
        #endregion

        #region セルの背景色を変更
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
        }
        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }
        private void tableLayoutPanel3_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }
        #endregion

        #region 担当者名入力チェック
        /// <summary>
        /// 担当者名入力チェック
        /// </summary>
        /// <remarks></remarks>
        private void textBox_StaffName_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTERキーが押されたかチェック
            if (e.KeyCode == Keys.Enter)
            {
                _logger.Info("担当者名入力チェック処理");

                // ENTERキーのみの場合のチェック
                if (txtStaffName.Text.Length == 0)
                {
                    return;
                }

                // 空文字チェック
                if (string.IsNullOrWhiteSpace(txtStaffName.Text))
                {
                    _logger.Info("担当者名が空文字です。担当者名を入力してください。");
                    MessageBox.Show("担当者名が空文字です。" + Environment.NewLine + "担当者名を入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ActiveControl = this.txtStaffName;
                    txtStaffName.Text = "";
                    return;
                }

                GlobalVar.STAFF_NAME = txtStaffName.Text;

                // 入力項目有効化
                inputMenuDefualtDisplay();
            }

        }
        #endregion

        #region 管理番号入力処理
        private void textBox_CONTROL_NO_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTERキーが押されたかチェック
            if (e.KeyCode == Keys.Enter)
            {
                // 入力した管理番号の桁数チェック
                if (txtControlNo.Text.Length != 20)
                {
                    new clsMessageBox().MessageBoxOKOnly("形式が異なります、再度、読み込んでください。", "私物登録", MessageBoxIcon.Warning);
                    txtControlNo.Text = "";
                    txtControlNo.Focus();
                    return;
                }

                // MS_RETURN_FLAG初期化
                GlobalVar.MS_RETURN_FLAG = "";

                dao = new daofrmMSPB200("DBConnection", GlobalVar.STAFF_NAME);

                DataTable dtPRM = null;
                DataTable dtDR = null;
                DataTable dtSDR = null;

                try
                {
                    // エスカレテーブルから入力した管理番号存在チェック
                    dt = dao.Select_T_ESCALATION(txtControlNo.Text);
                    _logger.Info($"エスカレテーブル取得数 [{dt.Rows.Count}]");
                }
                catch (Exception ex)
                {
                    _logger.Info("エスカレテーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                    new clsMessageBox().MessageBoxOKOnly("エスカレテーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                    return;
                }

                if (dt.Rows.Count <= 0)
                {
                    // プレドラ、ドラレコ、ステドラ順で出荷依頼テーブルから管理番号検索
                    try
                    {
                        _logger.Info("プレドラの出荷依頼テーブル検索：開始");
                        // プレドラの出荷依頼テーブルから入力した管理番号存在チェック
                        dtPRM = dao.Select_T_SHIPPING_REQUEST_PRM(txtControlNo.Text, _companyCode);
                    }
                    catch (Exception ex)
                    {
                        _logger.Info("プレドラの出荷依頼テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                        new clsMessageBox().MessageBoxOKOnly("プレドラの出荷依頼テーブルのデータ取得でエラーが発生しました。"+ Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        _logger.Info("プレドラの出荷依頼テーブル検索：終了");
                    }
                    _logger.Info("プレドラの出荷依頼テーブル取得数 [" + dt.Rows.Count + "]");

                    if (dtPRM.Rows.Count <= 0)
                    {
                        try
                        {
                            _logger.Info("ドラレコの出荷依頼テーブル検索：終了");
                            // ドラレコの出荷依頼テーブルから入力した管理番号存在チェック
                            dtDR = dao.Select_T_SHIPPING_REQUEST_DR(txtControlNo.Text, _companyCode);
                        }
                        catch (Exception ex)
                        {
                            _logger.Info("ドラレコの出荷依頼テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                            new clsMessageBox().MessageBoxOKOnly("ドラレコの出荷依頼テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {
                            _logger.Info("ドラレコの出荷依頼テーブル検索：終了");
                        }
                        _logger.Info("ドラレコの出荷依頼テーブル取得数 [" + dt.Rows.Count + "]");

                        if (dtDR.Rows.Count <= 0)
                        {
                            try
                            {
                                // ステドラの出荷依頼テーブルから入力した管理番号存在チェック
                                dtSDR = dao.Select_T_SHIPPING_REQUEST_SDR(txtControlNo.Text, _companyCode);
                            }
                            catch (Exception ex)
                            {
                                _logger.Info("ステドラの出荷依頼テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                                new clsMessageBox().MessageBoxOKOnly("ステドラの出荷依頼テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                                return;
                            }
                            finally
                            {
                                _logger.Info("ステドラの出荷依頼テーブル検索：終了");
                            }
                            _logger.Info("ステドラの出荷依頼テーブル取得数 [" + dt.Rows.Count + "]");

                            if (dtSDR.Rows.Count <= 0)
                            {
                                _logger.Info("プレドラ、ドラレコ、ステドラの出荷依頼テーブルに対象データは存在しません。");
                                new clsMessageBox().MessageBoxOKOnly("対象がありませんでした、確認してください。", "警告", MessageBoxIcon.Warning);
                                txtControlNo.Text = "";
                                lblContractNo.Text = "";
                                lblProductType.Text = "";
                                txtControlNo.Focus();
                                return;
                            }
                            else
                            {
                                // 画面上の「種別」「証券番号」に値セット
                                lblProductType.Text = _sdrName;

                                //「契約番号枝番｣省略の時は、"-"はセットしない
                                if (string.IsNullOrEmpty(dtSDR.Rows[0]["BRANCH_NO"].ToString()))
                                {
                                    lblContractNo.Text = dtSDR.Rows[0]["CONTRACT_NO"].ToString();
                                }
                                else
                                {
                                    lblContractNo.Text = String.Join("-", dtSDR.Rows[0]["CONTRACT_NO"].ToString(), dtSDR.Rows[0]["BRANCH_NO"].ToString());
                                }
                                
                                // 私物内容のCheckBoxとTextBox非活性
                                checkBoxETC.Enabled = true;
                                checkBoxPB1.Enabled = true;
                                checkBoxPB2.Enabled = true;
                                checkBoxPB3.Enabled = true;
                                checkBoxPB4.Enabled = true;
                                checkBoxPB5.Enabled = true;
                                checkBoxPB6.Enabled = true;
                                checkBoxPB7.Enabled = true;
                                checkBoxPB8.Enabled = true;
                                checkBoxPB9.Enabled = true;
                                checkBoxPB10.Enabled = true;                                

                                // 登録日TextBox非活性
                                txtRegistDate.Enabled = false;                                

                                //管理番号TextBox非活性
                                //txtControlNo.Enabled = false;

                                // QRコード作成
                                createQRCode(dtSDR.Rows[0]["CONTROL_NO"].ToString(), lblContractNo.Text, txtRegistDate.Text);

                                copyDT = dtSDR.Copy(); 
                            }
                        }
                        else
                        {
                            // 画面上の「種別」「証券番号」に値セット
                            lblProductType.Text = _drName;

                            //「契約番号枝番｣省略の時は、"-"はセットしない
                            if (string.IsNullOrEmpty(dtDR.Rows[0]["BRANCH_NO"].ToString()))
                            {
                                lblContractNo.Text = dtDR.Rows[0]["CONTRACT_NO"].ToString();
                            }
                            else
                            {
                                lblContractNo.Text = String.Join("-", dtDR.Rows[0]["CONTRACT_NO"].ToString(), dtDR.Rows[0]["BRANCH_NO"].ToString());
                            }

                            // 私物内容のCheckBoxとTextBox非活性
                            checkBoxETC.Enabled = true;
                            checkBoxPB1.Enabled = true;
                            checkBoxPB2.Enabled = true;
                            checkBoxPB3.Enabled = true;
                            checkBoxPB4.Enabled = true;
                            checkBoxPB5.Enabled = true;
                            checkBoxPB6.Enabled = true;
                            checkBoxPB7.Enabled = true;
                            checkBoxPB8.Enabled = true;
                            checkBoxPB9.Enabled = true;
                            checkBoxPB10.Enabled = true;                            

                            // 登録日TextBox非活性
                            txtRegistDate.Enabled = false;

                            //管理番号TextBox非活性
                            //txtControlNo.Enabled = false;

                            // QRコード作成
                            createQRCode(dtDR.Rows[0]["CONTROL_NO"].ToString(), lblContractNo.Text, txtRegistDate.Text);

                            copyDT = dtDR.Copy(); 
                        }
                    }
                    else
                    {
                        // 画面上の「種別」「証券番号」に値セット
                        lblProductType.Text = _prmName;

                        //「契約番号枝番｣省略の時は、"-"はセットしない
                        if (string.IsNullOrEmpty(dtPRM.Rows[0]["BRANCH_NO"].ToString()))
                        {
                            lblContractNo.Text = dtPRM.Rows[0]["CONTRACT_NO"].ToString();
                        }
                        else
                        {
                            lblContractNo.Text = String.Join("-", dtPRM.Rows[0]["CONTRACT_NO"].ToString(), dtPRM.Rows[0]["BRANCH_NO"].ToString());
                        }

                        // 私物内容のCheckBoxとTextBox非活性
                        checkBoxETC.Enabled = true;
                        checkBoxPB1.Enabled = true;
                        checkBoxPB2.Enabled = true;
                        checkBoxPB3.Enabled = true;
                        checkBoxPB4.Enabled = true;
                        checkBoxPB5.Enabled = true;
                        checkBoxPB6.Enabled = true;
                        checkBoxPB7.Enabled = true;
                        checkBoxPB8.Enabled = true;
                        checkBoxPB9.Enabled = true;
                        checkBoxPB10.Enabled = true;                        

                        // 登録日TextBox非活性
                        txtRegistDate.Enabled = false;

                        //管理番号TextBox非活性
                        //txtControlNo.Enabled = false;

                        // QRコード作成
                        createQRCode(dtPRM.Rows[0]["CONTROL_NO"].ToString(), lblContractNo.Text, txtRegistDate.Text);

                        copyDT = dtPRM.Copy(); 
                    }

                    GlobalVar.REGIST_DATE = txtRegistDate.Text;
                    GlobalVar.CONTROL_NO = txtControlNo.Text;
                    GlobalVar.REGIST_DATE = txtRegistDate.Text;
                    GlobalVar.CONTRACT_NO = lblContractNo.Text;
                    GlobalVar.PRODUCT_TYPE = lblProductType.Text;
                }
                else
                {
                    _logger.Info($"入力した管理番号（{txtControlNo.Text}）はエスカレテーブルに存在します。");

                    // 画面上の「種別」「証券番号」に値セット
                    lblProductType.Text = dt.Rows[0]["PRODUCT_TYPE"].ToString();
                    lblContractNo.Text = dt.Rows[0]["CONTRACT_NO"].ToString();

                    // QRコード作成
                    createQRCode(dt.Rows[0]["CONTROL_NO"].ToString(), lblContractNo.Text, dt.Rows[0]["REGIST_DATE"].ToString());

                    new clsMessageBox().MessageBoxOKOnly("登録済です。", "警告", MessageBoxIcon.Warning);
                    // 表示項目初期化
                    inputMenuDefualtDisplay();
                    return;
                }
            }
        }
        #endregion

        #region その他項目のチェックボックスのチェックイベント
        private void checkBox_Check(object sender, EventArgs e)
        {
            if (checkBoxETC.Checked)
            {
                txtETC.Enabled = true;
            }
            else
            {
                txtETC.Enabled = false;
            }
        }
        #endregion

        #endregion

        #region メソッド

        #region 私物内容表示
        private void checkList_Binding()
        {
            try
            {
                // 私物テーブルからデータを取得し、tablePanelにセット
                using (var dao = new daofrmMSPB200("DBConnection", GlobalVar.STAFF_NAME))
                {
                    dtCheckBoxList = dao.Select_T_PERSONAL_BELONGINGS();
                }
                _logger.Info("私物テーブル取得数 [" + dtCheckBoxList.Rows.Count + "]");
            }
            catch (Exception ex)
            {
                _logger.Info("私物テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                new clsMessageBox().MessageBoxOKOnly("私物テーブルのデータ取得でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                return;
            }

            if (dtCheckBoxList.Rows.Count <= 0)
            {
                _logger.Info("私物テーブルにデータが存在しません。");
            }
            else
            {
                // 私物テーブルより取得したデータを私物内容をセットして画面に表示
                checkBoxETC.Visible = true;
                labelETC.Visible = true;
                txtETC.Visible = true;

                for (int i = 0; i < dtCheckBoxList.Rows.Count; i++)
                {
                    // 最大10件まで表示
                    switch (i)
                    {
                        case 0:                            
                            checkBoxPB1.Visible = true;
                            labelPB1.Visible = true;
                            labelPB1.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 1:
                            checkBoxPB2.Visible = true;
                            labelPB2.Visible = true;
                            labelPB2.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 2:
                            checkBoxPB3.Visible = true;
                            labelPB3.Visible = true;
                            labelPB3.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 3:
                            checkBoxPB4.Visible = true;
                            labelPB4.Visible = true;
                            labelPB4.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 4:
                            checkBoxPB5.Visible = true;
                            labelPB5.Visible = true;
                            labelPB5.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 5:
                            checkBoxPB6.Visible = true;
                            labelPB6.Visible = true;
                            labelPB6.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 6:
                            checkBoxPB7.Visible = true;
                            labelPB7.Visible = true;
                            labelPB7.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 7:
                            checkBoxPB8.Visible = true;
                            labelPB8.Visible = true;
                            labelPB8.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 8:
                            checkBoxPB9.Visible = true;
                            labelPB9.Visible = true;
                            labelPB9.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        case 9:
                            checkBoxPB10.Visible = true;
                            labelPB10.Visible = true;
                            labelPB10.Text = dtCheckBoxList.Rows[i]["PERSONAL_BELONGINGS_CONTENTS"].ToString();
                            break;
                        default:                            
                            break;
                    }
                }

            }
        }
        #endregion

        #region 入力項目初期化
        private void inputMenuDefualtDisplay()
        {
            // MS_RETURN_FLAG初期化
            GlobalVar.MS_RETURN_FLAG = "";

            txtRegistDate.Text = System.DateTime.Now.ToString("yyyyMMdd");
            // 登録日DateTimePicker活性化                      
            txtRegistDate.Enabled = true;

            // 管理番号Textbox活性化
            txtControlNo.Enabled = true;
            txtControlNo.Text = "";
            txtControlNo.Focus();

            // 種別Label初期化
            lblProductType.Text = "";

            // 証券番号Label初期化
            lblContractNo.Text = "";

            // 私物内容CheckBoxのチェック解除
            checkBoxETC.Checked = false;
            checkBoxPB1.Checked = false;
            checkBoxPB2.Checked = false;
            checkBoxPB3.Checked = false;
            checkBoxPB4.Checked = false;
            checkBoxPB5.Checked = false;
            checkBoxPB6.Checked = false;
            checkBoxPB7.Checked = false;
            checkBoxPB8.Checked = false;
            checkBoxPB9.Checked = false;
            checkBoxPB10.Checked = false;

            // 私物内容CheckBoxの非活性
            checkBoxETC.Enabled = true;
            checkBoxPB1.Enabled = true;
            checkBoxPB2.Enabled = true;
            checkBoxPB3.Enabled = true;
            checkBoxPB4.Enabled = true;
            checkBoxPB5.Enabled = true;
            checkBoxPB6.Enabled = true;
            checkBoxPB7.Enabled = true;
            checkBoxPB8.Enabled = true;
            checkBoxPB9.Enabled = true;
            checkBoxPB10.Enabled = true;

            // 私物内容その他TextBox初期化
            txtETC.Text = "";

            // QRコード初期化
            picBoxQRCode.Image = null;

            // 登録件数活性化
            lblRegistCnt.Enabled = true;

            // 登録ボタン活性化
            btnRegist.Enabled = true;
        }

        #endregion

        #region QRコード作成
        private void createQRCode(string controlNo, string contractNo, string registDate)
        {
            // QRコードの文字
            string code = controlNo + "#" + Environment.NewLine + contractNo + Environment.NewLine + DateTime.ParseExact(registDate, "yyyyMMdd", null).ToString("yyyy/MM/dd"); ;

            try
            {
                var qrCode = new BarcodeWriter
                {
                    // バーコードの種類を選択
                    Format = BarcodeFormat.QR_CODE,
                    // QRコードのオプション設定
                    Options = new QrCodeEncodingOptions
                    {
                        QrVersion = 5,
                        ErrorCorrection = ErrorCorrectionLevel.M,
                        CharacterSet = "UTF-8",
                        Width = 160,
                        Height = 130,
                    },
                };

                //QRコード生成            
                Bitmap bmp = qrCode.Write(code);
                picBoxQRCode.Image = bmp;
            }
            catch(Exception ex)
            {
                _logger.Info("QRコード作成でエラーが発生しました。" + Environment.NewLine + ex.ToString());
                new clsMessageBox().MessageBoxOKOnly("QRコード作成でエラーが発生しました。" + Environment.NewLine + "開発部門に問い合わせ願います。", "エラー", MessageBoxIcon.Error);
                return;
            }
            

        }

        #endregion

        #region チェックされた私物内容の文字を結合
        private List<string> joinCheckedLabel()
        {
            List<string> checkedPBInfoName = new List<string>();
            List<string> itemName = new List<string>();
            List<string> joinList = new List<string>();
            string joinPBInfoName = null;            

            // チェックされたcheckboxの私物内容を結合
            if (checkBoxPB1.Checked == true)
            {
                checkedPBInfoName.Add(labelPB1.Text);
            }
            if (checkBoxPB2.Checked == true)
            {
                checkedPBInfoName.Add(labelPB2.Text);
            }
            if (checkBoxPB3.Checked == true)
            {
                checkedPBInfoName.Add(labelPB3.Text);
            }
            if (checkBoxPB4.Checked == true)
            {
                checkedPBInfoName.Add(labelPB4.Text);
            }
            if (checkBoxPB5.Checked == true)
            {
                checkedPBInfoName.Add(labelPB5.Text);
            }
            if (checkBoxPB6.Checked == true)
            {
                checkedPBInfoName.Add(labelPB6.Text);
            }
            if (checkBoxPB7.Checked == true)
            {
                checkedPBInfoName.Add(labelPB7.Text);
            }
            if (checkBoxPB8.Checked == true)
            {
                checkedPBInfoName.Add(labelPB8.Text);
            }
            if (checkBoxPB9.Checked == true)
            {
                checkedPBInfoName.Add(labelPB9.Text);
            }
            if (checkBoxPB10.Checked == true)
            {
                checkedPBInfoName.Add(labelPB10.Text);
            }
                        
            foreach (DataRow row in dtCheckBoxList.Rows)
            {
                if (row["MS_RETURN"].ToString() != "1" && checkedPBInfoName.Contains(row["PERSONAL_BELONGINGS_CONTENTS"].ToString()))
                {
                    itemName.Add(row["ITEM_NAME"].ToString());
                }
                else if(row["MS_RETURN"].ToString() == "1" && checkedPBInfoName.Contains(row["PERSONAL_BELONGINGS_CONTENTS"].ToString()))
                {
                    // MS返却フラグ
                    GlobalVar.MS_RETURN_FLAG = "1";
                    itemName.Add(row["ITEM_NAME"].ToString());
                }
            }

            if (checkBoxETC.Checked == true)
            {
                checkedPBInfoName.Add("その他（" + txtETC.Text + "）");
                itemName.Add("雑貨");
            }
            
            // チェックした私物内容を'、'で結合
            joinPBInfoName = string.Join("、", checkedPBInfoName);
            // 結合した文字が100文字を超えた場合、100文字までにする
            if (joinPBInfoName.Length > 100)
            {
                joinPBInfoName = joinPBInfoName.Substring(0, 100);
            }

            joinList.Add(joinPBInfoName);
            joinList.Add(itemName[0]);

            return joinList;
        }


        #endregion

        #endregion

        

    }
}
