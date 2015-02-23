using BootstrapRating.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    /// <exclude/>
    public enum BootstrapRatingOptions
    {
        /// <summary>
        /// Set the desired range (default start is 0 and stop is 5).
        /// </summary>
        [NameField(Name = "data-start")]
        start,

        /// <summary>
        /// Set the desired range (default start is 0 and stop is 5).
        /// </summary>
        [NameField(Name = "data-stop")]
        stop,

        /// <summary>
        /// Set the control as disabled.
        /// </summary>
        [NameField(Name = "disabled")]
        disabled,

        /// <summary>
        /// Set the control as read-only.
        /// </summary>
        [NameField(Name = "readonly")]
        readOnly,

        /// <summary>
        /// Set the rating value.
        /// </summary>
        [NameField(Name = "value")]
        value,

        /// <summary>
        /// Set the desired icons to be used in the control.
        /// </summary>
        [NameField(Name = "data-filled")]
        filledSymbols,

        /// <summary>
        /// Set the desired icons to be used in the control.
        /// </summary>
        [NameField(Name = "data-empty")]
        emptySymbols,

        /// <summary>
        /// Set the fractional rates. Indicates the number of equal parts that make up a whole symbol.
        /// </summary>
        [NameField(Name = "data-fractions")]
        fractions,

        /// <summary>
        /// Set the stepping increments used between start and stop.
        /// </summary>
        [NameField(Name = "data-step")]
        step,
    }
}