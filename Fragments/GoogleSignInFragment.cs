using Android.OS;
using Android.Views;
using AndroidX.Core.View;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationCodeLab.Fragments
{
    public class GoogleSignInFragment :  Fragment, IMenuProvider
    {
        public GoogleSignInFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            HasOptionsMenu = true;
            RequireActivity().AddMenuProvider(this);
            return inflater.Inflate(Resource.Layout.google_sign_in_fragment, container, false);
        }

        public void OnCreateMenu(IMenu menu, MenuInflater inflater) 
            => menu.Clear();

        public bool OnMenuItemSelected(IMenuItem menuItem)
            => false;
    }
}