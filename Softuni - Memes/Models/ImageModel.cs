﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace Softuni___Memes.Models
{
    [Table("Images")]
    public class ImageModel
    {
        public ImageModel()
        {
            this.AuthorId = HttpContext.Current.User.Identity.GetUserId();
        }

        [Key]
        public int Id { get; set; }

        [Column("image", TypeName = "image")]
        public byte[] Image { get; set; }

        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }

        public string AuthorId { get; set; }
    }
}