using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pageBuilder = new PageBuilder();
            var pageDirector = new PageDirector(pageBuilder);
            var page = pageDirector.BuildPage(123);
            Console.WriteLine(page);
            Console.ReadLine();
        }
    }  

    public interface IPageBuilder
    {
        void BuildHeader(string header);
        void BuildMenu(string menuitems);
        void BuildPost(string post);
        void BuildFooter(string footer);
        string GetResult();
    }

    public class PageBuilder : IPageBuilder
    {
        private string _page = string.Empty;
        public void BuildHeader(string header)
        {
            _page += header + Environment.NewLine;
        }
        public void BuildMenu(string menuitems) 
        {
            _page += menuitems + Environment.NewLine;
        }
        public void BuildPost(string post)
        {
            _page += post + Environment.NewLine;
        }
        public void BuildFooter(string footer) 
        {
            _page += footer + Environment.NewLine;
        }
        public string GetResult()
        {
            return _page;
        }
    }
    public class PrintPageBuilder : IPageBuilder
    {
        private string _page = string.Empty;
        public void BuildHeader(string header) { }
        public void BuildMenu(string menuitems) { }
        public void BuildPost(string post)
        {
            _page += post + Environment.NewLine;
        }
        public void BuildFooter(string footer) { }
        public string GetResult()
        {
            return _page;
        }
    }

    public class PageDirector
    {
        private readonly IPageBuilder _builder;
        public PageDirector(IPageBuilder builder)
        {
            _builder = builder;
        }
        public string BuildPage(int pageId)
        {
            _builder.BuildHeader(GetHeader(pageId));
            _builder.BuildMenu(GetMenuItems(pageId));
            foreach (var post in GetPosts(pageId))
            {
                _builder.BuildPost(post);
            }
            _builder.BuildFooter(GetFooter(pageId));
            return _builder.GetResult();
        }

        private string GetHeader(int pageId)
        {
            return "Header of page " + pageId;
        }
        private string GetMenuItems(int pageId)
        {
            return "Menu " + pageId;
        }
        private IEnumerable<string> GetPosts(int pageId)
        {
            return new List<string> { "Post 1", "Post 2" };
        }
        private string GetFooter(int pageId)
        {
            return "Footer of page " + pageId;
        }
    }
}
