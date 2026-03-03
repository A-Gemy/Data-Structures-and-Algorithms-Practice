using System;
using System.Collections.Generic;

namespace Browser_Back_Button
{
    class WebPage
    {
        public string Url { get; }
        public string Title { get; }

        public WebPage(string url, string title)
        {
            Url = url;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} ({Url})";
        }
    }

    class Browser
    {
        private Stack<WebPage> backStack = new Stack<WebPage>();
        private Stack<WebPage> forwardStack = new Stack<WebPage>();
        private WebPage currentPage;


        public void Visit(string url, string title)
        {
            if (currentPage != null)
            {
                backStack.Push(currentPage);
            }

            currentPage = new WebPage(url, title);
            forwardStack.Clear();

            Console.WriteLine($"Visited: {currentPage}");
        }

        public void Back()
        {
            if (backStack.Count == 0)
            {
                Console.WriteLine("No pages to go back to.");
                return;
            }

            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();

            Console.WriteLine($"Back to: {currentPage}");
        }

        public void Forward()
        {
            if (forwardStack.Count == 0)
            {
                Console.WriteLine("No pages to go forward to.");
                return;
            }

            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();

            Console.WriteLine($"Forward to: {currentPage}");
        }

        public void ShowCurrent()
        {
            if (currentPage == null)
                Console.WriteLine("No page opened yet.");
            else
                Console.WriteLine($"Current Page: {currentPage}");
        }
    }


    class Program
    {
        static void Main()
        {
            // Very basic solution 
            //Stack<string> history = new Stack<string>();

            //history.Push("Page1");
            //history.Push("Page2");
            //history.Push("Page3");

            //Console.WriteLine("Back from: " + history.Pop());
            //Console.WriteLine("Current Page: " + history.Peek());


            // Let's add more advanced one
            Browser browser = new Browser();

            browser.Visit("google.com", "Google");
            browser.Visit("youtube.com", "YouTube");
            browser.Visit("github.com", "GitHub");

            browser.Back();
            browser.Back();
            browser.Forward();

            browser.ShowCurrent();

            Console.ReadKey();
        }
    }
}
