﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.MvcApp.Models;

[Table("Tbl_Blog")]
public class BlogModel
{
    [Key]
    //[Column("BlogID")]
    public int BlogID { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
}
public class BlogMessageResponseModel
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}