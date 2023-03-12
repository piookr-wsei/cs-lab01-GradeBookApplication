using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighed) : base(name, isWeighed)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}

