#include "main.h"

LRESULT CALLBACK WndProc(HWND hwnd, UINT Message, WPARAM wParam, LPARAM lParam) {
    switch(Message) {
        case WM_CREATE: {
            CreateWindow("STATIC", "Shadow Browser Core Version",
                WS_VISIBLE | WS_CHILD,
                20, 5, 320, 20,
                hwnd, (HMENU) NULL, NULL, NULL);
            
            //Convert String to Char Array
            /* std::string coreverstring = coreVersion();
            int coreverlength = coreverstring.length();
            char coreVerArr[coreverlength + 1];
            strcpy(coreVerArr, coreverstring.c_str()); */
            CreateWindow("STATIC", StringToCharArr(coreVersion()),
                WS_VISIBLE | WS_CHILD,
                250, 5, 320, 20,
                hwnd, (HMENU) NULL, NULL, NULL);

            std::stringstream intConverter;
            intConverter << RandomNumber(252356);
            char const *int_as_char = intConverter.str().c_str();

            CreateWindow("STATIC", int_as_char,
                WS_VISIBLE | WS_CHILD,
                20, 100, 320, 20,
                hwnd, (HMENU) NULL, NULL, NULL);

            break;
        }

        /* Upon destruction, tell the main thread to stop */
        case WM_DESTROY: {
            PostQuitMessage(0);
            break;
        }

        default:
            return DefWindowProc(hwnd, Message, wParam, lParam);
    }
    return 0;
}

// Main function
// int main() {
// ^^^ I'm putting this here so that
// it's easier to find the main function in search
int WINAPI WinMain(HINSTANCE hInstance,
    HINSTANCE hPrevInstance,
    LPSTR lpCmdLine,
    int nCmdShow)
{
    WNDCLASSEX wc; /* A properties struct of our window */
    HWND hwnd;     /* Window Handle */
    MSG msg;       /* A temporary location for all messages */

    /* zero out the struct and set the stuff we want to modify */
    memset(&wc, 0, sizeof(wc));
    wc.cbSize        = sizeof(WNDCLASSEX);
    wc.lpfnWndProc   = WndProc; /* This is where we will send messages to */
    wc.hInstance     = hInstance;
    wc.hCursor       = LoadCursor(NULL, IDC_ARROW);

    wc.hbrBackground = (HBRUSH)(COLOR_WINDOWTEXT+1);
    wc.lpszClassName = "WindowClass";
    wc.hIcon         = LoadIcon(NULL, IDI_APPLICATION /* MAKEINTRESOURCEW(IDI_SHADOWBROWSER)*/);
    wc.hIconSm       = LoadIcon(NULL, IDI_APPLICATION /* MAKEINTRESOURCEW(IDI_SHADOWBROWSER)*/);

    if (!RegisterClassEx(&wc)) {
        MessageBox(NULL, "Something went wrong when trying to create the window. err 0", "ShadowBrowser ERROR", MB_ICONEXCLAMATION | MB_OK);
        return 0;
    }

    //Create the main window
    hwnd = CreateWindowEx(WS_EX_CLIENTEDGE, "WindowClass", "Shadow Browser", WS_VISIBLE | WS_OVERLAPPEDWINDOW,
        CW_USEDEFAULT, //X and Y positions of the window
        CW_USEDEFAULT, //CW_USEDEFAULT will let Windows decide
        1200, // Width
        850, //  Height
        NULL, NULL, hInstance, NULL);
    
    if (hwnd == NULL) {
        MessageBox(NULL, "Something went wrong when trying to create the window. err 1", "ShadowBrowser ERROR", MB_ICONEXCLAMATION | MB_OK);
        return 0;
    }

    /* This is where all of the messages get passed
       to be processed, this loop doesn't cause
       high cpu usage because GetMessage blocks code
       flow until it gets a message */
    
    while(GetMessage(&msg, NULL, 0, 0) > 0) { // Run loop if there is no error
        TranslateMessage(&msg); // key codes to chars
        DispatchMessage(&msg);  // send to WndProc
    }
    return msg.wParam;
}