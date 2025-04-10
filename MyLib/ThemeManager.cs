using System;

namespace MyLib
{
    //public enum 

    public class ThemeManager
    {
        public static string GetTableStyle(string theme)
        {
            switch (theme) {
                case "Светлая":
                    return "table,tbody{background-color:#fff}body,table{color:#333}*{margin:0;padding:0}body{background-color:#f0f0f0;margin:25px}.table-wrapper{display:block;border-radius:8px;overflow-x:auto;box-shadow:0 2px 4px rgba(0,0,0,.1)}table{width:100%;border-collapse:collapse}thead{background-color:#f9f9f9;border-bottom:1px solid #eee}th{padding:14px 16px;text-align:left;font-weight:500;letter-spacing:.5px;text-transform:uppercase}td{padding:12px 16px;border-bottom:1px solid #f0f0f0}tbody tr:nth-child(2n){background-color:#fafafa}tbody tr:hover{background-color:#f5f5f5;transition:background-color .2s}tbody tr:first-child td{border-top:1px solid #f0f0f0}tbody tr:last-child td{border-bottom:none}th:hover{background-color:#eaeaea;cursor:pointer}@media(max-width:768px){body{margin:20px}}@media(max-width:480px){body{margin:15px}}";
                case "Тёмная":
                    return "body,table{color:#e0e0e0}*{margin:0;padding:0}body{background-color:#121212;margin:25px}.table-wrapper{border-radius:8px;display:block;border-radius:8px;overflow-x:auto;box-shadow:0 4px 8px rgba(0,0,0,.2)}table{width:100%;border-collapse:collapse;}thead{background-color:#333;border-bottom:1px solid #555}th{padding:14px 16px;text-align:left;font-weight:500;letter-spacing:.5px;text-transform:uppercase}tbody{background-color:#222}td{padding:12px 16px;border-bottom:1px solid #444}tbody tr:nth-child(2n){background-color:#282828}tbody tr:hover{background-color:#3a3a3a;transition:background-color .2s}tbody tr:first-child td{border-top:1px solid #444}tbody tr:last-child td{border-bottom:none}th:hover{background-color:#444;cursor:pointer}@media(max-width:768px){body{margin:20px}}@media(max-width:480px){body{margin:15px}}";
                case "Зелёная":
                    return "table,tbody{background-color:#fff}body,tbody tr:nth-child(2n){background-color:#f0f0f0}body,table{color:#333}*{margin:0;padding:0}body{margin:25px}.table-wrapper{border-radius:8px;display:block;border-radius:8px;overflow-x:auto;box-shadow:0 2px 4px rgba(0,0,0,.1)}table{width:100%;border-collapse:collapse}thead{background-color:#009879;border-bottom:1px solid #007a5e;color:#fff}th{padding:14px 16px;text-align:left;font-weight:500;letter-spacing:.5px;text-transform:uppercase}td{padding:12px 16px;border-bottom:1px solid #e0e0e0}tbody tr:hover{background-color:#e5e5e5;transition:background-color .2s}tbody tr:first-child td{border-top:1px solid #e0e0e0}tbody tr:last-child td{border-bottom:none}th:hover{background-color:#007a5e;cursor:pointer}@media(max-width:768px){body{margin:20px}}@media(max-width:480px){body{margin:15px}}";
                default:
                    return "";
            }
        }
    }
}
