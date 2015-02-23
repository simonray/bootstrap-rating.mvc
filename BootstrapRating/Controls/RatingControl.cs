using BootstrapRating.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace BootstrapRating.Controls
{
    /// <inheritDoc/>
    internal class RatingControl : IRatingControl
    {
        /// <exclude/>
        private TagBuilder _input = new TagBuilder("input");
        /// <exclude/>
        private string _class = "rating";

        /// <inheritDoc/>
        public RatingControl(string id = null, double value = 0)
        {
            if (string.IsNullOrEmpty(id) == false)
                _input.Attributes.Add("name", id);
            if (value > 0)
                Set(BootstrapRatingOptions.value, value);
        }

        #region IHtmlString
        /// <exclude/>
        public string ToHtmlString()
        {
            _input.AddCssClass(_class);
            _input.Attributes.Add("type", "hidden");
            return _input.ToString(TagRenderMode.Normal);
        }
        #endregion

        /// <inheritDoc/>
        public IRatingControl Set(BootstrapRatingOptions option)
        {
            _input.Attributes.Add(option.FieldName(), true.ToStringLower());
            return this;
        }

        /// <inheritDoc/>
        public IRatingControl Set(BootstrapRatingOptions option, object value)
        {
            _input.Attributes.Add(option.FieldName(), value.ToString());
            return this;
        }

        /// <inheritDoc/>
        public IRatingControl Class(string value)
        {
            _class = value;
            return this;
        }

        /// <inheritDoc/>
        public IRatingControl Value(double value)
        {
            return Set(BootstrapRatingOptions.value, value);
        }

        /// <inheritDoc/>
        public IRatingControl ReadOnly
        {
            get { return Set(BootstrapRatingOptions.readOnly); }
        }

        /// <inheritDoc/>
        public IRatingControl Disabled
        {
            get { return Set(BootstrapRatingOptions.disabled); }
        }

        /// <inheritDoc/>
        public IRatingControl Symbols(string filledSymbols, string emptySymbols)
        {
            Set(BootstrapRatingOptions.filledSymbols, filledSymbols);
            return Set(BootstrapRatingOptions.emptySymbols, emptySymbols);
        }

        /// <inheritDoc/>
        public IRatingControl Fractions(int fraction)
        {
            return Set(BootstrapRatingOptions.fractions, fraction);
        }

        /// <inheritDoc/>
        public IRatingControl Start(int start)
        {
            return Set(BootstrapRatingOptions.start, start);
        }

        /// <inheritDoc/>
        public IRatingControl Stop(int stop)
        {
            return Set(BootstrapRatingOptions.stop, stop);
        }

        /// <inheritDoc/>
        public IRatingControl Step(int step)
        {
            return Set(BootstrapRatingOptions.step, step);
        }
    }
}