﻿using Blog.Models;
using Blog.Models.Comments;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        public Post GetPost(int id);
        List<Post> GetAllPosts();       
        IndexViewModel GetAllPosts(int pageNumber, string category, string search);        
        void AddPost(Post post);       
        void UpdatePost(Post post);
        void RemovePost(int id);
        void AddSubComment(SubComment comment);
            
        Task<bool> SaveChangesAsync();


    }
}
