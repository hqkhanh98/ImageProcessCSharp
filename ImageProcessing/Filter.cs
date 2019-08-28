using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
        /**
         * @ Author : Huỳnh Quốc Khánh
         * @ Date Create : 25/8/2019
         * @ Project : Image Processing
         */
    class Filter
    {
        /**
         * Đây là hàm sắp xếp các phần tử
         * @param int[]
         * @param int
         */
        public static void Sort(int[] arr, int size)
        {
            //Khởi tạo
            int temp, i, j;
            //Duyệt tuần tự từng phần tử trong mảng
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    //Nếu vị trí i > j thì hoán đổi cho nhau
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        /**
         * Đây là hàm bộ lọc trung vị, có đầu vào là 1 bitmap hình ảnh
         * Duyệt lần lượt các điểm ảnh sau đó sắp xếp các điểm ảnh
         * Chọn điểm ảnh nằm ở vị trí trung tâm của mảng
         * Trả về hình ảnh sau khi lọc
         * @param Bitmap
         * @return Bitmap
         */
        public static Bitmap medianFilter(Bitmap bitmap, int offset)
        {
            //Khởi tạo
            int width = bitmap.Width;
            int height = bitmap.Height;
            int size = offset * offset;

            int i, j;
            Bitmap bmResult = new Bitmap(width, height);

            int[] R = new int[size];
            int[] G = new int[size];
            int[] B = new int[size];

            //===================       3X3     =======================//
            if (offset == 3 ) {
                //Duyệt lần lượt toàn bộ điểm ảnh
                for (i = 1; i < width - 1; i++)
                {
                    for (j = 1; j < height - 1; j++)
                    {
                        // ============ RED =================//
                        //Dòng 1
                        R[0] = bitmap.GetPixel(i - 1, j - 1).R;
                        R[1] = bitmap.GetPixel(i - 1, j).R;
                        R[2] = bitmap.GetPixel(i - 1, j + 1).R;

                        //Dòng 2
                        R[3] = bitmap.GetPixel(i, j - 1).R;
                        R[4] = bitmap.GetPixel(i, j).R;
                        R[5] = bitmap.GetPixel(i, j + 1).R;
                        //Dòng 3
                        R[6] = bitmap.GetPixel(i + 1, j - 1).R;
                        R[7] = bitmap.GetPixel(i + 1, j).R;
                        R[8] = bitmap.GetPixel(i + 1, j + 1).R;

                        // ============ GREEN =================//
                        //Dòng 1
                        G[0] = bitmap.GetPixel(i - 1, j - 1).G;
                        G[1] = bitmap.GetPixel(i - 1, j).G;
                        G[2] = bitmap.GetPixel(i - 1, j + 1).G;
                        //Dòng 2
                        G[3] = bitmap.GetPixel(i, j).G;
                        G[4] = bitmap.GetPixel(i, j).G;
                        G[5] = bitmap.GetPixel(i, j).G;
                        //Dòng 3
                        G[6] = bitmap.GetPixel(i + 1, j - 1).G;
                        G[7] = bitmap.GetPixel(i + 1, j).G;
                        G[8] = bitmap.GetPixel(i + 1, j + 1).G;

                        // ============ BLUE =================//
                        //Dòng 1
                        B[0] = bitmap.GetPixel(i - 1, j - 1).B;
                        B[1] = bitmap.GetPixel(i - 1, j).B;
                        B[2] = bitmap.GetPixel(i - 1, j + 1).B;
                        //Dòng 2
                        B[3] = bitmap.GetPixel(i, j - 1).B;
                        B[4] = bitmap.GetPixel(i, j).B;
                        B[5] = bitmap.GetPixel(i, j + 1).B;
                        //Dòng 3
                        B[6] = bitmap.GetPixel(i - 1, j - 1).B;
                        B[7] = bitmap.GetPixel(i - 1, j).B;
                        B[8] = bitmap.GetPixel(i - 1, j + 1).B;

                        //Sắp xếp
                        Sort(R, 9);
                        Sort(G, 9);
                        Sort(B, 9);

                        //Chọn điểm pixel nằm ở trung tâm mảng
                        bmResult.SetPixel(i, j, Color.FromArgb(R[4], G[4], B[4]));
                    }
                }
            }
            //===================       5X5     =======================//
            else if ( offset == 5 )
            {
                //Duyệt lần lượt toàn bộ điểm ảnh
                for (i = 2; i < width - 2; i++)
                {
                    for (j = 2; j < height - 2; j++)
                    {
                        // ============ RED =================//
                        //Dòng 1
                        R[0] = bitmap.GetPixel(i - 2, j - 2).R;
                        R[1] = bitmap.GetPixel(i - 2, j - 1).R;
                        R[2] = bitmap.GetPixel(i - 2, j).R;
                        R[3] = bitmap.GetPixel(i - 2, j + 1).R;
                        R[4] = bitmap.GetPixel(i - 2, j + 2).R;

                        //Dòng 2
                        R[5] = bitmap.GetPixel(i - 1, j - 2).R;
                        R[6] = bitmap.GetPixel(i - 1, j - 1).R;
                        R[7] = bitmap.GetPixel(i - 1, j).R;
                        R[8] = bitmap.GetPixel(i - 1, j + 1).R;
                        R[9] = bitmap.GetPixel(i - 1, j + 2).R;
                        //Dòng 3
                        R[10] = bitmap.GetPixel(i, j - 2).R;
                        R[11] = bitmap.GetPixel(i, j - 1).R;
                        R[12] = bitmap.GetPixel(i, j).R;
                        R[13] = bitmap.GetPixel(i, j + 1).R;
                        R[14] = bitmap.GetPixel(i, j + 2).R;
                        //Dong 4
                        R[15] = bitmap.GetPixel(i + 1, j - 2).R;
                        R[16] = bitmap.GetPixel(i + 1, j - 1).R;
                        R[17] = bitmap.GetPixel(i + 1, j).R;
                        R[18] = bitmap.GetPixel(i + 1, j + 1).R;
                        R[19] = bitmap.GetPixel(i + 1, j + 2).R;
                        //Dong 5
                        R[20] = bitmap.GetPixel(i + 2, j - 2).R;
                        R[21] = bitmap.GetPixel(i + 2, j - 1).R;
                        R[22] = bitmap.GetPixel(i + 2, j).R;
                        R[23] = bitmap.GetPixel(i + 2, j + 1).R;
                        R[24] = bitmap.GetPixel(i + 2, j + 2).R;

                        // ============ GREEN =================//
                        G[0] = bitmap.GetPixel(i - 2, j - 2).G;
                        G[1] = bitmap.GetPixel(i - 2, j - 1).G;
                        G[2] = bitmap.GetPixel(i - 2, j).G;
                        G[3] = bitmap.GetPixel(i - 2, j + 1).G;
                        G[4] = bitmap.GetPixel(i - 2, j + 2).G;

                        //Dòng 2
                        G[5] = bitmap.GetPixel(i - 1, j - 2).G;
                        G[6] = bitmap.GetPixel(i - 1, j - 1).G;
                        G[7] = bitmap.GetPixel(i - 1, j).G;
                        G[8] = bitmap.GetPixel(i - 1, j + 1).G;
                        G[9] = bitmap.GetPixel(i - 1, j + 2).G;
                        //Dòng 3
                        G[10] = bitmap.GetPixel(i, j - 2).G;
                        G[11] = bitmap.GetPixel(i, j - 1).G;
                        G[12] = bitmap.GetPixel(i, j).G;
                        G[13] = bitmap.GetPixel(i, j + 1).G;
                        G[14] = bitmap.GetPixel(i, j + 2).G;
                        //Dong 4
                        G[15] = bitmap.GetPixel(i + 1, j - 2).G;
                        G[16] = bitmap.GetPixel(i + 1, j - 1).G;
                        G[17] = bitmap.GetPixel(i + 1, j).G;
                        G[18] = bitmap.GetPixel(i + 1, j + 1).G;
                        G[19] = bitmap.GetPixel(i + 1, j + 2).G;
                        //Dong 5
                        G[20] = bitmap.GetPixel(i + 2, j - 2).G;
                        G[21] = bitmap.GetPixel(i + 2, j - 1).G;
                        G[22] = bitmap.GetPixel(i + 2, j).G;
                        G[23] = bitmap.GetPixel(i + 2, j + 1).G;
                        G[24] = bitmap.GetPixel(i + 2, j + 2).G;

                        // ============ BLUE =================//
                        //Dòng 1
                        B[0] = bitmap.GetPixel(i - 2, j - 2).B;
                        B[1] = bitmap.GetPixel(i - 2, j - 1).B;
                        B[2] = bitmap.GetPixel(i - 2, j).B;
                        B[3] = bitmap.GetPixel(i - 2, j + 1).B;
                        B[4] = bitmap.GetPixel(i - 2, j + 2).B;

                        //Dòng 2
                        B[5] = bitmap.GetPixel(i - 1, j - 2).B;
                        B[6] = bitmap.GetPixel(i - 1, j - 1).B;
                        B[7] = bitmap.GetPixel(i - 1, j).B;
                        B[8] = bitmap.GetPixel(i - 1, j + 1).B;
                        B[9] = bitmap.GetPixel(i - 1, j + 2).B;
                        //Dòng 3
                        B[10] = bitmap.GetPixel(i, j - 2).B;
                        B[11] = bitmap.GetPixel(i, j - 1).B;
                        B[12] = bitmap.GetPixel(i, j).B;
                        B[13] = bitmap.GetPixel(i, j + 1).B;
                        B[14] = bitmap.GetPixel(i, j + 2).B;
                        //Dong 4
                        B[15] = bitmap.GetPixel(i + 1, j - 2).B;
                        B[16] = bitmap.GetPixel(i + 1, j - 1).B;
                        B[17] = bitmap.GetPixel(i + 1, j).B;
                        B[18] = bitmap.GetPixel(i + 1, j + 1).B;
                        B[19] = bitmap.GetPixel(i + 1, j + 2).B;
                        //Dong 5
                        B[20] = bitmap.GetPixel(i + 2, j - 2).B;
                        B[21] = bitmap.GetPixel(i + 2, j - 1).B;
                        B[22] = bitmap.GetPixel(i + 2, j).B;
                        B[23] = bitmap.GetPixel(i + 2, j + 1).B;
                        B[24] = bitmap.GetPixel(i + 2, j + 2).B;

                        //Sắp xếp
                        Sort(R, 25);
                        Sort(G, 25);
                        Sort(B, 25);

                        //Chọn điểm pixel nằm ở trung tâm mảng
                        bmResult.SetPixel(i, j, Color.FromArgb(R[13], G[13], B[13]));
                    }
                }
            }
           
            return bmResult;
        }
        /**
         * Đây là hàm bộ lọc trung bình, có đầu vào là 1 bitmap hình ảnh
         * Duyệt lần lượt các điểm ảnh sau đó tính tổng các điểm ảnh
         * Sau khi đã có tổng thì chia trung bình
         * Trả về hình ảnh sau khi lọc
         * @param Bitmap
         * @return Bitmap
         */
        public static Bitmap averageFilter(Bitmap bitmap)
        {
            //Khởi tạo
            int width = bitmap.Width;
            int height = bitmap.Height;
            int i, j;
            int[] R = new int[9];
            int[] G = new int[9];
            int[] B = new int[9];

            int sumR = 0;
            int sumG = 0;
            int sumB = 0;
            int avgR, avgG, avgB;

            Bitmap bmResult = new Bitmap(width, height);
            //=============================================//
            //Duyệt lần lượt toàn bộ điểm ảnh
            for (i = 1; i < width - 1; i++)
            {
                for (j = 1; j < height - 1; j++)
                {
                    // ============ RED =================//
                    //Dòng 1
                    R[0] = bitmap.GetPixel(i - 1, j - 1).R;
                    R[1] = bitmap.GetPixel(i - 1, j).R;
                    R[2] = bitmap.GetPixel(i - 1, j + 1).R;
                    //Dòng 2
                    R[3] = bitmap.GetPixel(i, j - 1).R;
                    R[4] = bitmap.GetPixel(i, j).R;
                    R[5] = bitmap.GetPixel(i, j + 1).R;
                    //Dòng 3
                    R[6] = bitmap.GetPixel(i + 1, j - 1).R;
                    R[7] = bitmap.GetPixel(i + 1, j).R;
                    R[8] = bitmap.GetPixel(i + 1, j + 1).R;

                    // ============ GREEN =================//
                    //Dòng 1
                    G[0] = bitmap.GetPixel(i - 1, j - 1).G;
                    G[1] = bitmap.GetPixel(i - 1, j).G;
                    G[2] = bitmap.GetPixel(i - 1, j + 1).G;
                    //Dòng 2
                    G[3] = bitmap.GetPixel(i, j).G;
                    G[4] = bitmap.GetPixel(i, j).G;
                    G[5] = bitmap.GetPixel(i, j).G;
                    //Dòng 3
                    G[6] = bitmap.GetPixel(i + 1, j - 1).G;
                    G[7] = bitmap.GetPixel(i + 1, j).G;
                    G[8] = bitmap.GetPixel(i + 1, j + 1).G;

                    // ============ BLUE =================//
                    //Dòng 1
                    B[0] = bitmap.GetPixel(i - 1, j - 1).B;
                    B[1] = bitmap.GetPixel(i - 1, j).B;
                    B[2] = bitmap.GetPixel(i - 1, j + 1).B;
                    //Dòng 2
                    B[3] = bitmap.GetPixel(i, j - 1).B;
                    B[4] = bitmap.GetPixel(i, j).B;
                    B[5] = bitmap.GetPixel(i, j + 1).B;
                    //Dòng 3
                    B[6] = bitmap.GetPixel(i - 1, j - 1).B;
                    B[7] = bitmap.GetPixel(i - 1, j).B;
                    B[8] = bitmap.GetPixel(i - 1, j + 1).B;

                    //Tính tổng 9 điểm ảnh
                    sumR = R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7] + R[8];
                    sumG = G[0] + G[1] + G[2] + G[3] + G[4] + G[5] + G[6] + G[7] + G[8];
                    sumB = B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6] + B[7] + B[8];

                    //Chia trung bình
                    avgR = sumR / 9;
                    avgG = sumG / 9;
                    avgB = sumB / 9;

                    //Xuất điểm ảnh trung bình
                    bmResult.SetPixel(i, j, Color.FromArgb(avgR, avgG, avgB));

                    //Reset toàn bộ biến cần thiết
                    sumR = 0; sumG = 0; sumB = 0; avgR = 0; avgG = 0; avgB = 0;
                }
            }

            return bmResult;
        }
    }
}
