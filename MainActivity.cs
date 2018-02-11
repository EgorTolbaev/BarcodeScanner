using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Gms.Vision.Barcodes;
using Android.Gms.Vision;
using Android.Graphics;
using Android.Runtime;
using System;
using Android.Support.V4.App;
using Android;
using Android.Content.PM;
using static Android.Gms.Vision.Detector;
using Android.Util;
using Android.Content;

namespace XamarinQrCodeCamera
{
    [Activity(Label = "Barcode Scanner", MainLauncher = true, Icon = "@drawable/icon",Theme="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity,ISurfaceHolderCallback,IProcessor
    {
        public static int pressedButton = 0;

        public void ReceiveDetections(Detections detections)
        {
            throw new NotImplementedException();
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            

            Button qr = FindViewById<Button>(Resource.Id.button1);
            Button code = FindViewById<Button>(Resource.Id.button2);
            Button ean = FindViewById<Button>(Resource.Id.button3);

            qr.Click += delegate
            {
                Intent intent = new Intent(this, typeof(CodeSelection));
                StartActivity(intent);
                pressedButton = 1;
            };

            code.Click += delegate
            {
                Intent intent = new Intent(this, typeof(CodeSelection));
                StartActivity(intent);
                pressedButton = 2;
            };

            ean.Click += delegate
            {
                Intent intent = new Intent(this, typeof(CodeSelection));
                StartActivity(intent);
                pressedButton = 3;
            };
        }

      
    }
}

