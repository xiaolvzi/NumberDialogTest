using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App79.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(IDisplayDialogImpl))]
namespace App79.Droid
{
    public class IDisplayDialogImpl :Activity, IDispalyDialog
    {
        public async void displayDialog()
        {
            string Number = "";
            try
            {
                EditText et = new EditText(MainActivity.mContext)
                {
                    InputType = Android.Text.InputTypes.NumberFlagDecimal | Android.Text.InputTypes.ClassNumber
                };

                AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.mContext);
                builder.SetTitle("Enter Quantity");
                builder.SetPositiveButton("OK", delegate
                {
                    if (!string.IsNullOrEmpty(et.Text))
                        Number = et.Text;

                    MessagingCenter.Send<Object, string>(this, "Hi", Number);
                });
                builder.SetNegativeButton("CANCEL", delegate { builder.Dispose(); });
                builder.SetView(et);
                builder.SetCancelable(false);
                AlertDialog alertdialog = builder.Create();

                alertdialog.Show();

                alertdialog.GetButton((int)DialogButtonType.Positive).Enabled = false;

                et.AfterTextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(et.Text))
                    {
                        alertdialog.GetButton((int)DialogButtonType.Positive).Enabled = true;
                    }
                };
                while (string.IsNullOrEmpty(Number))
                {
                    await Task.Delay(25);
                }


            }

            catch (Exception ex)
            {
                Toast.MakeText(MainActivity.mContext, ex.Message, ToastLength.Long).Show();
                // ex.Message;
                

            }
        }
    }
}