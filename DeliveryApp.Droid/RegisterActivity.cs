using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DeliveryApp.Droid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText registerEmailEditText, registerPasswordEditText, registerConfirmPasswordEditText;
        Button registerUserButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Register);

            registerEmailEditText = FindViewById<EditText>(Resource.Id.registerEmailEditText);
            registerPasswordEditText = FindViewById<EditText>(Resource.Id.registerPasswordEditText);
            registerUserButton = FindViewById<Button>(Resource.Id.registeruUserButton);
            registerConfirmPasswordEditText = FindViewById<EditText>(Resource.Id.registerConfirmPasswordEditText);

            registerUserButton.Click += RegisterUserButton_Click;

        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
        }
    }
}