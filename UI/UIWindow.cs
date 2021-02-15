using OpenGL;
using OpenGL.Platform;
using System.Numerics;
using System.Text;
using OpenTK;
using UI.Controls;
using UI.Core;

namespace UI
{
    public class UIWindow
    {
        public void SetUpWindow(WindowType windowType)
        {
            switch (windowType)
            {
                case WindowType.Unknown:
                    break;
                case WindowType.MainMenu:
                    SetUpMainMenuWindow();
                    break;
                case WindowType.Menu:
                    break;
                default:
                    break;
            }
        }

        public void Start()
        {
            Window.CreateWindow("A game TEXT_RESOURCE", 1280, 720);

            // add a reshape callback to update the UI
            Window.OnReshapeCallbacks.Add(() => UserInterface.OnResize(Window.Width, Window.Height));

            // add a close callback to make sure we dispose of everything properly
            Window.OnCloseCallbacks.Add(OnClose);

            // enable depth testing to ensure correct z-ordering of our fragments
            Gl.Enable(EnableCap.DepthTest);
            Gl.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            // initialize the user interface
            UserInterface.InitUI(Window.Width, Window.Height);

            // create some centered text
            Text welcome = new Text(Text.FontSize._24pt, "Welcome to OpenGL", BMFont.Justification.Center)
            {
                RelativeTo = Corner.Center
            };

            // create some colored text
            Text coloredText = new Text(Text.FontSize._24pt, "using C#", BMFont.Justification.Center)
            {
                Position = new Point(0, -30),
                Color = new Vector3(0.2f, 0.3f, 1f),
                RelativeTo = Corner.Center
            };

            // add the two text object to the UI
            UserInterface.AddElement(welcome);
            UserInterface.AddElement(coloredText);

            // subscribe the escape event using the OpenGL.UI class library
            Input.Subscribe((char)27, Window.OnClose);

            // make sure to set up mouse event handlers for the window
            Window.OnMouseCallbacks.Add(UserInterface.OnMouseClick);
            Window.OnMouseMoveCallbacks.Add(UserInterface.OnMouseMove);
        }

        public void SetUpMainMenuWindow()
        {

        }

        private static void OnClose()
        {
            // make sure to dispose of everything
            UserInterface.Dispose();
            BMFont.Dispose();
        }

        private static void OnRenderFrame()
        {
            // set up the OpenGL viewport and clear both the color and depth bits
            Gl.Viewport(0, 0, Window.Width, Window.Height);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // draw the user interface after everything else
            UserInterface.Draw();

            // finally, swap the back buffer to the front so that the screen displays
            Window.SwapBuffers();
        }

        private static void OnMouseClick(int button, int state, int x, int y)
        {
            // take care of mapping the Glut buttons to the UI enums
            if (!UserInterface.OnMouseClick(button + 1, (state == 0 ? 1 : 0), x, y))
            {
                // do other picking code here if necessary
            }
        }

        private static void OnMouseMove(int x, int y)
        {
            if (!UserInterface.OnMouseMove(x, y))
            {
                // do other picking code here if necessary
            }
        }
    }
}
