﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace PostComment.APIStatic
{
    public static class API
    {
        public static bool AddPost(Post post)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                bool bResult = false;
                if (post.Id == 0)
                {
                    var it = ctx.Entry<Post>(post).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public static Post UpdatePost(Post newPost)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                // Ce e in bd. PK nu poate fi modificata
                Post oldPost = ctx.Posts.Find(newPost.Id);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public static int DeletePost(int id)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);
            }
        }
        /// <summary>
        /// Returnez un Post si toate Comment-urile asociate lui
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Post GetPostById(int id)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                var items = from p in ctx.Posts where (p.Id == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null;
            }
        }
        /// <summary>
        /// Returnez toate Post-urile si Comment-urile corespunzatoare
        /// </summary>
        /// <returns></returns>
        public static List<Post> GetAllPosts()
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }
        // Comment table
        public static bool AddComment(Comment comment)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                bool bResult = false;
                if (comment == null || comment.PostPostId == 0)
                    return bResult;
                if (comment.PostId == 0)
                {
                    ctx.Entry<Comment>(comment).State = EntityState.Added;
                    Post p = ctx.Posts.Find(comment.PostPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public static Comment UpdateComment(Comment newComment)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                Comment oldComment = ctx.Comments.Find(newComment.PostId);
                if (newComment.Text != null)
                    oldComment.Text = newComment.Text;
                if ((oldComment.PostPostId != newComment.PostPostId)
               && (newComment.PostPostId != 0))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public static Comment GetCommentById(int id)
        {
            using (PostCommentModelContainer ctx = new PostCommentModelContainer())
            {
                var items = from c in ctx.Comments where (c.PostId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}
