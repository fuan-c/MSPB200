using System;
using System.Windows.Forms;
using MSPB200.MSPB200;

//グローバル変数
public static class GlobalVar
{
    public static string STAFF_NAME;                // 担当者名
    public static string REGIST_DATE;               // 登録日
    public static string CONTROL_NO;                // 管理番号
    public static string CONTRACT_NO;               // 証券番号
    public static string PRODUCT_TYPE;              // 種別
    public static string MS_RETURN_FLAG;            // MS返却フラグ
}

namespace MSPB200
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMSPB200());
        }
    }
}
