using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace SocialMediaMaui.Controls;

public class NoBorderEditor : Editor
{
    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
#if ANDROID
        SetBorderlessBackground();
#endif
    }

    private void SetBorderlessBackground()
    {
#if ANDROID
        if (Handler is IEditorHandler entryHandler)
        {
            if (BackgroundColor == null)
            {
                entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            }
            else
            {
                entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
            }
        }
#endif
    }
}
