using ShimLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace RandomImage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lbxRandomAlgorithm.SelectedIndex = 0;
        }
        [DllImport("msvcrt")] public static extern int rand();
        
        static int next = 0;
        public static int MyRand() {
            next = next * 1103515245 + 12345;
            return (int)(next / 65536) % 32768;
        }        
        public static void MySrand(int seed) {
            next = seed;
        }

        ImageBuffer imgBuf;

        private unsafe void RandomImage_CRTrand() {
            for (int y = 0; y < imgBuf.Height; y++) {
                var ptr = (byte*)imgBuf.Buffer + imgBuf.Step * y;
                for (int x = 0; x < imgBuf.Width; x++, ptr++) {
                    int gray = rand() % 256;
                    *ptr = *(byte*)&gray;
                }
            }
        }

        private unsafe void RandomImage_SystemRandom() {
            Random rnd = new Random();
            for (int y = 0; y < imgBuf.Height; y++) {
                var ptr = (byte*)imgBuf.Buffer + imgBuf.Step * y;
                for (int x = 0; x < imgBuf.Width; x++, ptr++) {
                    int gray = rnd.Next(256);
                    *ptr = *(byte*)&gray;
                }
            }
        }

        private unsafe void RandomImage_MyRand() {
            for (int y = 0; y < imgBuf.Height; y++) {
                var ptr = (byte*)imgBuf.Buffer + imgBuf.Step * y;
                for (int x = 0; x < imgBuf.Width; x++, ptr++) {
                    int gray = MyRand() % 256;
                    *ptr = *(byte*)&gray;
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e) {
            switch (lbxRandomAlgorithm.SelectedIndex) {
                case 0:
                    RandomImage_SystemRandom();
                    break;
                case 1:
                    RandomImage_CRTrand();
                    break;
                case 2:
                    RandomImage_MyRand();
                    break;
            }
            ibxDraw.Redraw();
        }

        private void btnAlloc_Click(object sender, EventArgs e) {
            if (imgBuf != null)
                imgBuf.Dispose();
            int width = (int)numWidth.Value;
            int height = (int)numHeight.Value;
            imgBuf = new ImageBuffer(width, height, ImageBufferFormat.Gray8);
            ibxDraw.SetImageBuffer(imgBuf.Buffer, imgBuf.Width, imgBuf.Height, 8, imgBuf.Step, imgBuf.BufferFormat, null);
            ibxDraw.Redraw();
        }
    }

    public class ImageBuffer : IDisposable {
        public int Width { get; } = 0;
        public int Height { get; } = 0;
        public int Step { get; } = 0;
        public ImageBufferFormat BufferFormat { get; } = ImageBufferFormat.Undefined;
        public IntPtr Buffer { get; } = IntPtr.Zero;
        public bool External { get; } = false;

        #region IDisposable Support
        private bool disposedValue = false; // 중복 호출을 검색하려면

        public ImageBuffer(int width, int height, int step, IntPtr buffer, ImageBufferFormat bufferFormat) {
            Width = width;
            Height = height;
            Step = step;
            BufferFormat = bufferFormat;
            Buffer = buffer;
            External = true;
        }

        public ImageBuffer(int width, int height, ImageBufferFormat bufferFormat) {
            Width = width;
            Height = height;
            Step = Width;
            BufferFormat = bufferFormat;
            Buffer = Marshal.AllocHGlobal(Step * Height);
            External = false;
        }

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: 관리되는 상태(관리되는 개체)를 삭제합니다.
                }

                // TODO: 관리되지 않는 리소스(관리되지 않는 개체)를 해제하고 아래의 종료자를 재정의합니다.
                if (External)
                    Marshal.FreeHGlobal(Buffer);
                // TODO: 큰 필드를 null로 설정합니다.

                disposedValue = true;
            }
        }

        // TODO: 위의 Dispose(bool disposing)에 관리되지 않는 리소스를 해제하는 코드가 포함되어 있는 경우에만 종료자를 재정의합니다.
        // ~ImageBuffer() {
        //   // 이 코드를 변경하지 마세요. 위의 Dispose(bool disposing)에 정리 코드를 입력하세요.
        //   Dispose(false);
        // }

        // 삭제 가능한 패턴을 올바르게 구현하기 위해 추가된 코드입니다.
        public void Dispose() {
            // 이 코드를 변경하지 마세요. 위의 Dispose(bool disposing)에 정리 코드를 입력하세요.
            Dispose(true);
            // TODO: 위의 종료자가 재정의된 경우 다음 코드 줄의 주석 처리를 제거합니다.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
