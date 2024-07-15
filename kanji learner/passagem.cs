using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kanji_learner
{
    class passagem
    {
        public static int hiraganaMain_selected;
        public static int hiraganaDakuten_selected;
        public static int hiraganaCombination_selected;
        public static int KatakanaMain_selected;
        public static int KatakanDakuten_selected;
        public static int KatakanCombination_selected;
        public static int ComfirmacaoResposta=1;
        public static int tamanhotabela;
        public static List<string> symbol = new List<string>();
        public static List<string> erradas = new List<string>();
        public static string coneccaoSQL = @"Data Source=(LocalDb)\MSSQLLocalDB;DataBase=bdJPWRITINGSYSTEM;Trusted_Connection=True;Column Encryption Setting=Enabled;";
        public static SqlConnection liga = new SqlConnection(@"" + coneccaoSQL + ""); 
    }
}