using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;

namespace HelloThree
{
    public class Window : GameWindow
    {
        //public Window(GameWindowSettings gameSettings, NativeWindowSettings nativeSettings)
        public Window(Vector2i size, string title)
            : base(GameWindowSettings.Default, new NativeWindowSettings() {ClientSize = size, Title = title})
        {
        }
        
        // override functions to plug into OpenTK
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            if(KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }
            base.OnUpdateFrame(args);
        }
    }
}
