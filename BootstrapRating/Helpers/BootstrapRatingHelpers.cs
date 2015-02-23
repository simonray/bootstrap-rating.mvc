using BootstrapRating.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace System.Web.Mvc
{
    /// <exclude/>
    public static class BootstrapRatingExtensions
    {
        /// <summary>
        /// Returns a BootstrapRating control.
        /// </summary>
        /// <param name="helper">The HTML helper instance that this method extends.</param>
        /// <returns>Html representation of the control.</returns>
        public static IRatingControl BootstrapRating(this HtmlHelper helper)
        {
            return new RatingControl();
        }

        /// <summary>
        /// Returns a BootstrapRating control.
        /// </summary>
        /// <typeparam name="TModel">Model.</typeparam>
        /// <typeparam name="TProperty">Property.</typeparam>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="expression">Property.</param>
        /// <returns>Html representation of the control.</returns>
        public static IRatingControl BootstrapRating<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            return new RatingControl(metadata.PropertyName, (double)metadata.Model);
        }
    }
}