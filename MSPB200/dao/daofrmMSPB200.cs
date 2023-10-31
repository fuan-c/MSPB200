using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using log4net;
using MSPB200.Common.Dao;
using Oracle.ManagedDataAccess.Client;

namespace MSPB200.dao
{
    class daofrmMSPB200 : daoBase
    {

        #region "変数"

        // ユーザーID
        string _userId = string.Empty;

        // log4netLogger変数
        private ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        

        // コンストラクタ
        public daofrmMSPB200(string name, string userid)
        {
            dbConnection(name);
            _userId = userid;

        }

        #region "SELECT"

        #region  私物テーブルより取得
        // 私物テーブルより取得
        public DataTable Select_T_PERSONAL_BELONGINGS()
        {
            StringBuilder sb = new StringBuilder();
            string sql = String.Empty;
            DataTable tbl = new DataTable();

            _logger.Info("〇Select_T_PERSONAL_BELONGINGS");

            sb.AppendLine("SELECT ");
            sb.AppendLine(" NO ");
            sb.AppendLine(" ,PERSONAL_BELONGINGS_CONTENTS ");
            sb.AppendLine(" ,MS_RETURN ");
            sb.AppendLine(" ,ITEM_NAME ");
            sb.AppendLine(" FROM T_PERSONAL_BELONGINGS ");            
            sb.AppendLine(" ORDER BY NO ");

            sql = sb.ToString();
            _logger.Info("sql[" + Environment.NewLine + sql + "]");
            tbl = base.Fill(sql);

            _logger.Info("私物内容 取得終了");           

            return tbl;
        }
        #endregion

        #region  エスカレテーブルより取得
        // エスカレテーブルより取得
        public DataTable Select_T_ESCALATION(string controlNo)
        {
            _logger.Info("〇Select_T_ESCALATION");

            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine(" REGIST_DATE ");
            sql.AppendLine(" ,PRODUCT_TYPE ");
            sql.AppendLine(" ,CONTROL_NO ");
            sql.AppendLine(" ,CONTRACT_NO ");
            sql.AppendLine(" FROM T_ESCALATION ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("  CONTROL_NO = :CONTROL_NO ");

            DataTable dt = new DataTable();

            _logger.Info("sql[" + Environment.NewLine + sql + "]");

            using (OracleCommand cmd = new OracleCommand(sql.ToString(), this.Connection) { BindByName = true })
            {
                cmd.Parameters.Add(":CONTROL_NO", controlNo);
                
                foreach (OracleParameter prm in cmd.Parameters)
                {
                    this._logger.InfoFormat("{0}[{1}]", prm.ParameterName, prm.Value == null ? "<Null>" : prm.Value.ToString());
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            
            return dt;
        }
        #endregion

        #region  エスカレテーブルのMAXのID取得
        // エスカレテーブルより取得
        public DataTable Select_T_ESCALATION_MAX_ID()
        {
            StringBuilder sb = new StringBuilder();
            string sql = String.Empty;
            DataTable dt = new DataTable();

            _logger.Info("〇Select_T_ESCALATION_MAX_ID");

            sb.AppendLine("SELECT ");
            sb.AppendLine(" MAX(ID) AS MAX_ID");
            sb.AppendLine(" FROM T_ESCALATION ");

            sql = sb.ToString();
            _logger.Info("sql[" + Environment.NewLine + sql + "]");
            dt = base.Fill(sql);

            _logger.Info("ユーザ情報 取得終了");

            return dt;
        }
        #endregion

        #region  プレドラの出荷依頼テーブルより取得
        // プレドラの出荷依頼テーブルより取得
        public DataTable Select_T_SHIPPING_REQUEST_PRM(string controlNo, string companyCode)
        {
            _logger.Info("〇Select_T_SHIPPING_REQUEST_PRM");

            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine(" CONTROL_NO ");
            sql.AppendLine(" ,CONTRACT_NO ");
            sql.AppendLine(" ,BRANCH_NO ");
            sql.AppendLine(" ,CONTRACTOR_NAME ");
            sql.AppendLine(" ,SEND_DEST_NAME ");
            sql.AppendLine(" ,SEND_DEST_POSTAL_CODE ");
            sql.AppendLine(" ,SEND_DEST_ADDRESS ");
            sql.AppendLine(" ,SEND_DEST_TEL_NO");
            sql.AppendLine(" FROM T_SHIPPING_REQUEST_PRM ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("  CONTROL_NO = :CONTROL_NO ");
            sql.AppendLine("  AND INSURANCE_CODE = :INSURANCE_CODE ");

            DataTable dt = new DataTable();

            _logger.Info("sql[" + Environment.NewLine + sql + "]");

            using (OracleCommand cmd = new OracleCommand(sql.ToString(), this.Connection) { BindByName = true })
            {
                cmd.Parameters.Add(":CONTROL_NO", controlNo);
                cmd.Parameters.Add(":INSURANCE_CODE", companyCode);

                foreach (OracleParameter prm in cmd.Parameters)
                {
                    this._logger.InfoFormat("{0}[{1}]", prm.ParameterName, prm.Value == null ? "<Null>" : prm.Value.ToString());
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            
            return dt;
        }

        #endregion

        #region  ドラレコの出荷依頼テーブルより取得
        // ドラレコの出荷依頼テーブルより取得
        public DataTable Select_T_SHIPPING_REQUEST_DR(string controlNo, string companyCode)
        {
            _logger.Info("〇Select_T_SHIPPING_REQUEST_DR");

            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine(" CONTROL_NO ");
            sql.AppendLine(" ,CONTRACT_NO ");
            sql.AppendLine(" ,BRANCH_NO ");
            sql.AppendLine(" ,CONTRACTOR_NAME ");
            sql.AppendLine(" ,SEND_DEST_NAME ");
            sql.AppendLine(" ,SEND_DEST_POSTAL_CODE ");
            sql.AppendLine(" ,SEND_DEST_ADDRESS ");
            sql.AppendLine(" ,SEND_DEST_TEL_NO");
            sql.AppendLine(" FROM T_SHIPPING_REQUEST_DR ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("  CONTROL_NO = :CONTROL_NO ");
            sql.AppendLine("  AND INSURANCE_CODE = :INSURANCE_CODE ");

            DataTable dt = new DataTable();

            _logger.Info("sql[" + Environment.NewLine + sql + "]");

            using (OracleCommand cmd = new OracleCommand(sql.ToString(), this.Connection) { BindByName = true })
            {
                cmd.Parameters.Add(":CONTROL_NO", controlNo);
                cmd.Parameters.Add(":INSURANCE_CODE", companyCode);

                foreach (OracleParameter prm in cmd.Parameters)
                {                    
                    this._logger.InfoFormat("{0}[{1}]", prm.ParameterName, prm.Value == null ? "<Null>" : prm.Value.ToString());
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }            

            return dt;
        }

        #endregion

        #region  ステドラの出荷依頼テーブルより取得
        // ステドラの出荷依頼テーブルより取得
        public DataTable Select_T_SHIPPING_REQUEST_SDR(string controlNo, string companyCode)
        {
            _logger.Info("〇Select_T_SHIPPING_REQUEST_SDR");

            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT ");
            sql.AppendLine(" CONTROL_NO ");
            sql.AppendLine(" ,CONTRACT_NO ");
            sql.AppendLine(" ,BRANCH_NO ");
            sql.AppendLine(" ,CONTRACTOR_NAME ");
            sql.AppendLine(" ,SEND_DEST_NAME ");            
            sql.AppendLine(" ,SEND_DEST_POSTAL_CODE ");
            sql.AppendLine(" ,SEND_DEST_ADDRESS ");
            sql.AppendLine(" ,SEND_DEST_TEL_NO");
            sql.AppendLine(" FROM T_SHIPPING_REQUEST_SDR ");
            sql.AppendLine("WHERE ");
            sql.AppendLine("  CONTROL_NO = :CONTROL_NO ");
            sql.AppendLine("  AND INSURANCE_CODE = :INSURANCE_CODE ");

            DataTable dt = new DataTable();

            _logger.Info("sql[" + Environment.NewLine + sql + "]");

            using (OracleCommand cmd = new OracleCommand(sql.ToString(), this.Connection) { BindByName = true })
            {
                cmd.Parameters.Add(":CONTROL_NO", controlNo);
                cmd.Parameters.Add(":INSURANCE_CODE", companyCode);

                foreach (OracleParameter prm in cmd.Parameters)
                {                    
                    this._logger.InfoFormat("{0}[{1}]", prm.ParameterName, prm.Value == null ? "<Null>" : prm.Value.ToString());
                }

                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }            

            return dt;
        }

        #endregion

        #endregion

        #region "INSERT"

        #region "エスカレテーブルデータ登録"
        public void Insert_T_ESCALATION(decimal maxId, List<string> joinList, DataTable dt)
        {
            try
            {
                //トランザクション開始
                BeginTransaction();

                _logger.Info("エスカレテーブルデータ登録 開始");
                _logger.Info("〇insert_T_ESCALATION");

                StringBuilder sb = new StringBuilder();
                string sql = null;

                // 直近の日曜日計算
                DateTime dateTime = DateTime.ParseExact(GlobalVar.REGIST_DATE, "yyyyMMdd", null);
                DateTime sundayOfNextWeek;  // 直近の日曜日
                DateTime storagePeriod;     // 直近の日曜日 + 31日

                // 登録日が日曜日の場合は当日をセット、それ以外は直近の日曜日をセット
                if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayOfNextWeek = dateTime;
                    storagePeriod = sundayOfNextWeek.AddDays(31);
                }
                else
                {
                    int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)dateTime.DayOfWeek + 7) % 7;
                    sundayOfNextWeek = dateTime.AddDays(daysUntilSunday);
                    storagePeriod = sundayOfNextWeek.AddDays(31);
                }

                _logger.Info($"エスカレテーブルデータ 登録1行 ID：[{maxId}]、REGIST_DATE：[{GlobalVar.REGIST_DATE}]、PRODUCT_TYPE：[{GlobalVar.PRODUCT_TYPE}]、CONTROL_NO：[{GlobalVar.CONTROL_NO}]、CONTRACT_NO：[{GlobalVar.CONTRACT_NO}]、STATUS：[0]、PERSONAL_BELONGINGS_INFO：[{joinList[0]}]、ITEM_NAME：[{joinList[1]}]、MS_RETURN_FLAG：[{GlobalVar.MS_RETURN_FLAG}]、STORAGE_REFERENCE_DATE：[{sundayOfNextWeek}]、STORAGE_PERIOD：[{storagePeriod}]、ESCALATION_RESPONSE[0]、CONTRACTOR_NAME[{dt.Rows[0]["CONTRACTOR_NAME"].ToString()}]、SEND_DEST_NAME[{dt.Rows[0]["SEND_DEST_NAME"].ToString()}]、SEND_DEST_POSTAL_CODE[{dt.Rows[0]["SEND_DEST_POSTAL_CODE"].ToString()}]、SEND_DEST_ADDRESS[{dt.Rows[0]["SEND_DEST_ADDRESS"].ToString()}]、SEND_DEST_TEL_NO[{dt.Rows[0]["SEND_DEST_TEL_NO"].ToString()}]、REGIST_USER_NAME[{_userId}]");

                sb.AppendLine(" INSERT INTO T_ESCALATION ( ");
                sb.AppendLine("   ID ");
                sb.AppendLine("   ,REGIST_DATE ");
                sb.AppendLine("   ,PRODUCT_TYPE ");
                sb.AppendLine("   ,CONTROL_NO ");
                sb.AppendLine("   ,CONTRACT_NO ");
                sb.AppendLine("   ,STATUS ");
                sb.AppendLine("   ,PERSONAL_BELONGINGS_INFO ");
                sb.AppendLine("   ,ITEM_NAME ");
                sb.AppendLine("   ,MS_RETURN_FLAG ");
                sb.AppendLine("   ,STORAGE_REFERENCE_DATE ");
                sb.AppendLine("   ,STORAGE_PERIOD ");
                sb.AppendLine("   ,ESCALATION_RESPONSE ");
                sb.AppendLine("   ,CONTRACTOR_NAME ");
                sb.AppendLine("   ,SEND_DEST_NAME ");
                sb.AppendLine("   ,SEND_DEST_POSTAL_CODE ");
                sb.AppendLine("   ,SEND_DEST_ADDRESS ");
                sb.AppendLine("   ,SEND_DEST_TEL_NO ");
                sb.AppendLine("   ,REGIST_USER_NAME ");
                sb.AppendLine("  ) VALUES (");
                sb.AppendLine("  " + maxId);
                sb.AppendLine("  ,'" + GlobalVar.REGIST_DATE + "'");
                sb.AppendLine("  ,'" + GlobalVar.PRODUCT_TYPE + "'");
                sb.AppendLine("  ,'" + GlobalVar.CONTROL_NO + "'");
                sb.AppendLine("  ,'" + GlobalVar.CONTRACT_NO + "'");
                sb.AppendLine("  ,'0'");
                sb.AppendLine("  ,'" + joinList[0] + "'");
                sb.AppendLine("  ,'" + joinList[1] + "'");
                sb.AppendLine("  ,'" + GlobalVar.MS_RETURN_FLAG + "'");
                sb.AppendLine("  ,'" + sundayOfNextWeek.ToShortDateString() + "'");
                sb.AppendLine("  ,'" + storagePeriod.ToShortDateString() + "'");                
                sb.AppendLine("  ,'0'");
                sb.AppendLine("  ,'" + dt.Rows[0]["CONTRACTOR_NAME"].ToString() + "'");
                sb.AppendLine("  ,'" + dt.Rows[0]["SEND_DEST_NAME"].ToString() + "'");
                sb.AppendLine("  ,'" + dt.Rows[0]["SEND_DEST_POSTAL_CODE"].ToString() + "'");
                sb.AppendLine("  ,'" + dt.Rows[0]["SEND_DEST_ADDRESS"].ToString() + "'");
                sb.AppendLine("  ,'" + dt.Rows[0]["SEND_DEST_TEL_NO"].ToString() + "'");
                sb.AppendLine("  ,'" + _userId + "'");
                sb.AppendLine(")");
                
                _logger.Info("sql[" + Environment.NewLine + sb.ToString() + "]");
                sql = sb.ToString();
                Update(sql);
                
                //コミット
                Commit();
            }
            catch (Exception ex)
            {
                //ロールバック
                Rollback();
                throw new Exception("エスカレテーブルデータ登録処理：" + ex.Message, ex);
            }
            finally
            {
                _logger.Info("エスカレテーブルデータ登録 終了");
            }
        }
        #endregion
        #endregion

        #region "UPDATE"

        #endregion

    }
}
