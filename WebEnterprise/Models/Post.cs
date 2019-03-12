﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebEnterprise.Models
{
    public class Post
    {
        //The post ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int postId { get; set; }
        // Foreign key to customer
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string postTitle { get; set; }
        public string postBody { get; set; }
        public string postDescription { get; set; }
        public string postCategory { get; set; }
        public bool postAnonymous { get; set; }
        public bool likeORdislike { get; set; }
        //public string postLikes { get; set; }
        //public string postDislikes { get; set; }

       // private ApplicationDbContext _dbContext;

        //public Post()
        //{
           // this._dbContext = new ApplicationDbContext();
       // }

        //public void AddToDatabase()
        //{
        //    _dbContext.Posts.Add(this);
        //    _dbContext.SaveChanges();

        //}



    }
}