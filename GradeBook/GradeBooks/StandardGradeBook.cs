using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        StandardGradeBook(string name, GradeBookType type) : base(name)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}
}
