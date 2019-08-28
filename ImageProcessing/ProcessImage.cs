using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class ProcessImage
    {
        /**
         * @ Author : Huỳnh Quốc Khánh
         * @ Date Create : 28/8/2019
         * @ Project : Image Processing
         */
        /*
         * Đây là hàm chuyển đổi ảnh từ kênh màu RGB sang Gray scale
         * Duyệt toàn bộ các pixel trong ma trận
         * Tại mỗi điểm ta tính trung bình cộng 
         * Xuất ảnh
         */
        public static Bitmap convertRGBToGray(Bitmap bitmap)
        {
            //Khởi tạo
            int width = bitmap.Width;
            int height = bitmap.Height;
            int size = width * height;
            int i, j;
            int R, G, B, avg;
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for ( i = 0; i < width; i++)
            {
                for ( j = 0; j < height; j++)
                {
                    R = bitmap.GetPixel(i, j).R;
                    G = bitmap.GetPixel(i, j).G;
                    B = bitmap.GetPixel(i, j).B;
                    
                    avg = (R + G + B) / 3;

                    result.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                    R = 0; G = 0; B = 0; avg = 0;
                }
            }
            return result;
        }
        /*
         * Đây là hàm chuyển đổi ảnh từ kênh màu RGB sang Sepia
         * Duyệt toàn bộ các pixel trong ma trận
         * Tại mỗi điểm ta tính dựa trên công thức R * 0.299 + G * 0.587 + B *0.144
         * Kiểm tra điều kiện R > 206 = 255 : G < 14 = 0: B < 14 = 0
         * Xuất ảnh
         */
        public static Bitmap convertRGBToSepia(Bitmap bitmap)
        {
            //Khởi tạo
            int width = bitmap.Width;
            int height = bitmap.Height;
            int size = width * height;
            int i, j;
            int R, G, B, sepia;
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (i = 0; i < width; i++)
            {
                for (j = 0; j < height; j++)
                {
                    R = bitmap.GetPixel(i, j).R;
                    G = bitmap.GetPixel(i, j).G;
                    B = bitmap.GetPixel(i, j).B;
                    sepia = (int)((R * 0.299) + (G * 0.587) + (B * 0.144));
                    if (sepia > 206)
                    {
                        R = 255;
                    }
                    else if (sepia < 56)
                    {
                        B = 0;
                    }
                    else if (sepia < 14)
                    {
                        G = 0;
                    }
                    else
                    {
                        R = sepia + 49;
                        B = sepia - 56;
                        G = sepia - 14;
                    }
                    result.SetPixel(i, j, Color.FromArgb(R, G, B));

                    R = 0; G = 0; B = 0; sepia = 0;
                }
            }
            return result;
        }
    }
}
