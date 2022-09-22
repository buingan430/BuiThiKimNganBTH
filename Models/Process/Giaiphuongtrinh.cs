using Microsoft.AspNetCore.Mvc;

namespace PTPMQL .Models.Process
{
    public class Giaiphuongtrinh 
    {
        // xây dựng các phương thức
        
        public string GiaiphuongtrinhBacNhat(double hesoA, double hesoB)
        {
            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
            string message = "";
            double x;
            if(hesoA == 0){
                if(hesoB ==0){
                    message = "phuong tirnh co vo so  nghiem";
                }
                else{
                    message = "phuong trinh vo nghiem";
                }
            }
            else{
                x = -hesoB / hesoA;
                message = " phuong tirnh co nghiem x :" +x;
            }
            return message;
        }
 
        // Giai pt bac 2
         public string GiaiphuongtrinhBacHai (double hesoA, double hesoB, double hesoC)
         {
        string thongbao = "";
        double delta, x1, x2, x3;
         
        if (hesoA==0)
        {
                thongbao = GiaiphuongtrinhBacNhat(hesoB, hesoC);
                if(hesoB ==0)
                {
                    if(hesoC ==0)
                    {
                        thongbao = "phuong trinh vo so nghiem";
                        
                    }
                    else
                    {
                        thongbao = "phuong trinh vo nghiem";
                    }
                }
                else
                {
                    x1 =  -hesoC / hesoB;
                    thongbao  = " phuong trinh có nghiem duy nhat" +x1;
                }
        }
            
        else
        {
            
            delta = Math.Pow(hesoB,2) -4 * hesoA * hesoC;
            if(delta < 0)
            {
                thongbao  = "phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                x2 = x3 = -hesoB / (2 * hesoA);
                thongbao  = "phuong trinh co nghiem kep x2, x3:" +x2;
            }
            else
            {
                x2 = (-hesoB + Math.Sqrt(delta)) / (2 * hesoA);
                x3 = (-hesoB - Math.Sqrt(delta)) / (2 * hesoA);
                thongbao  = "phuong trinh co 2 nghiem phan biet:"  +x2 + " và " +x3;
            }
        
        }
        return thongbao;
        }
    
    }
    
}