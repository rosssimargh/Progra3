using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace aplsumar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText a = FindViewById<EditText>(Resource.Id.txtintroduzca);
            Button calcular = FindViewById<Button>(Resource.Id.btncalcular);
            RadioGroup radio = FindViewById<RadioGroup>(Resource.Id.radio);
            RadioButton r1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
            RadioButton r2 = FindViewById<RadioButton>(Resource.Id.radioButton2);
            TextView resul = FindViewById<TextView>(Resource.Id.txtresultado);
            calcular.Click += (sender, e) =>
            {
                string s = r1.Text;
                
              


            };
        }


        int sumatoria(int n)
        {
            if (n == 0)
                return 1;
            else
                return sumatoria(n - 1) + n;
        }
        int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return factorial(n - 1) * n;
        }

    }




}