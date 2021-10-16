using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson5.Task4_Store
{
    class Store
    {
        private Article[] _articles;

        public Article[] Articles
        {
            get { return _articles; }
        }

        public Article this[int index]
        {
            get { return _articles[index]; }
            set { _articles[index] = value; }
        }

        #region Constructors
        public Store(Article article)
        {
            _articles = new Article[1];
            _articles[0] = article;
        }

        public Store(int number)
        {
            _articles = new Article[number];
        }

        public Store(Article[] articles)
        {
            _articles = articles;
        }
        #endregion

        public Article GetArticle(string name)
        {
            return _articles.Select(x => x).Where(x => x.Name == name).FirstOrDefault();
        }

        public Article GetArticle(int index)
        {
            if (index >= 0 && index < _articles.Length)
            {
                return _articles[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool AddProduct(Article article)
        {
            bool result = true;
            Article[] temp;
            try
            {
                for (int i = 0; i < _articles.Length; i++)
                {
                    if (_articles[i] == null)
                    {
                        _articles[i] = article;
                        return true;
                    }
                }
                temp = new Article[_articles.Length + 1];
                _articles.CopyTo(temp, 0);
                temp[^1] = article;
                _articles = temp;
           }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        public bool DeleteProduct(int i)
        {
            bool result;
            if (i >= 0 && i < _articles.Length)
            {
                _articles[i] = null;
                result = true;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            return result;
        }

        public string GetInfo()
        {
            string result = string.Empty;
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] == null)
                {
                    result += $"Product{i}: nothing"+System.Environment.NewLine;
                }
                else
                {
                    result += $"Product{i}: name: {_articles[i].Name}, price: {_articles[i].Price}, name of store: {_articles[i].StoreName}"+System.Environment.NewLine;
                }
            }
            return result;
        }
    }
}
