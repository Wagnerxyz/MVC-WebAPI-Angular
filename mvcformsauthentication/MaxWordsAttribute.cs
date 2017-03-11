using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcformsauthentication
{
    /// <summary>
    /// 最大单词数，判断空格。支持自定义错误提示消息
    /// </summary>
    public class MaxWordsAttribute:ValidationAttribute
    {
        private int _maxWords;

        public MaxWordsAttribute(int maxwords):base("{0} has too many words")
        {
            _maxWords = maxwords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                var valueAsstring = value.ToString();
                if (valueAsstring.Split(' ').Length>_maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);

                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}