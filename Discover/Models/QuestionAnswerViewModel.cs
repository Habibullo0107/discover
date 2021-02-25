using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class QuestionAnswerViewModel
    {
        public string QuestionText { get; set; }
        public VariantForSelecting VariantA { get; set; }
        public VariantForSelecting VariantB { get; set; }
        public VariantForSelecting VariantC { get; set; }
        public VariantForSelecting VariantD { get; set; }
    }

    public class VariantForSelecting
    {
        public Variant Variant { get; set; }

        public bool IsSelected { get; set; }
    }
}
