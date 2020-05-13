using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace Etapa5.Pages.Comments
{
    public class CreateModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public CreateModel()
        {
            CommentDTO = new Models.CommentDTO();
        }
        [BindProperty]
        public Models.CommentDTO CommentDTO { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id.HasValue)
            {
                var itemPost = await pcc.GetPostByIdAsync(id.Value);
                ViewData["id"] = id.Value.ToString() + " : " + itemPost.Description;
                CommentDTO.PostPostId = id.Value;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ServiceReferencePostComment.CommentDTO comment = new ServiceReferencePostComment.CommentDTO(); // acest tip este vazut in serviciu
            int postId = 0;
            postId = id.Value;
            comment.PostPostId = postId;
            comment.Text = CommentDTO.Text;
            var result = await pcc.AddCommentAsync(comment);
            if (!result)
            {
                return RedirectToAction("Error");
            }
            return RedirectToPage("/Posts/Index");
        }
    }
}