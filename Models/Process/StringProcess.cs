using Microsoft.AspNetCore.Mvc;

namespace PTPMQL .Models.Process
{
    public class StringProcess :Controller
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
           string result = " ";
            // viet code xu lý 
            //xóa bỏ ký tự trắng
            strInput =  strInput.Trim();
            // Xóa bỏ chuỗi
            int index = strInput.IndexOf("  ");
            while (strInput.IndexOf("  ") > 0) {
                strInput = strInput.Replace("  ", " ");
             }
            result = strInput;
            return result;
        }
        // viết hoa tất cả
        public string LowerToUpper (string strInput)
        {
            string strResult = " ";
            strInput = strInput.ToUpper();
            strResult  = strInput;
            return strResult;
        }
        // viết thường
        public string UpperToLower (string strInput)
        {
            string str = " ";
            strInput = strInput.ToLower();
            str = strInput;
            return str;
        }
        // viết hoa chữ cái đầu tiên
        public string CapitalizeOneFirstCharacter (string strInput)
        {
            string strResult = " ";
            string firstCharacter = strInput.Substring(0,1).ToUpper();
            strResult = firstCharacter + strInput.Substring(1);
            return strResult;
        }
        // viết hoa các chữ cái đầu tiên
         public string CapitalizeFirstCharacter (string strInput)
        {
            string strResult = " ";
           string[] chuoi = strInput.Split(" ");
           for (int i=0; i< chuoi.Length; i++)
           {
            if (chuoi[i] != "")
            {
                chuoi[i] = CapitalizeOneFirstCharacter(chuoi[i]);
            }
           }
           strResult = string.Join(" ", chuoi);
            return strResult;
        }
        // 
        public string RemoveVietnameseAccents( string strInput)
            {
            string remove = "";
                string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                            "đ",
                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                            "í","ì","ỉ","ĩ","ị",
                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                            "ý","ỳ","ỷ","ỹ","ỵ"};
                string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                            "d",
                            "e","e","e","e","e","e","e","e","e","e","e",
                            "i","i","i","i","i",
                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                            "u","u","u","u","u","u","u","u","u","u","u",
                            "y","y","y","y","y"};
                for (int i = 0; i < arr1.Length; i++)
                {
                    strInput = strInput.Replace(arr1[i], arr2[i]);
                    strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
                }
                remove = strInput;
                return remove;
            }

    
    }
}
