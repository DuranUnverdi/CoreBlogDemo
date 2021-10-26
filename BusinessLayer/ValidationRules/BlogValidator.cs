using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Bırakmayınız...");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Bırakmayınız...");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Bırakmayınız...");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden az veri girişi yapınız");
            RuleFor(x => x.BlogTitle).MinimumLength(10).WithMessage("Lütfen 10 karakterden fazla veri girişi yapınız");
        }
    }
}
