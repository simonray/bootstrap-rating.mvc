using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BootstrapRating.Controls
{
    /// <summary>
    /// Simple to use Html Helper for the jQuery bootstrap-rating plug-in.
    /// </summary>
    public interface IRatingControl : IHtmlString
    {
        /// <summary>
        /// Set an option against the control (value = true).
        /// </summary>
        IRatingControl Set(BootstrapRatingOptions option);

        /// <summary>
        /// Set an option against the control.
        /// </summary>
        IRatingControl Set(BootstrapRatingOptions option, object value);

        /// <summary>
        /// Set/overrite the class of the control (default = "rating").
        /// </summary>
        IRatingControl Class(string @class);
        
        /// <summary>
        /// Set the current rating value.
        /// </summary>
        IRatingControl Value(double value);
        
        /// <summary>
        /// Set the control as read-only.
        /// </summary>
        IRatingControl ReadOnly { get; }
        
        /// <summary>
        /// Set the control as disabled.
        /// </summary>
        IRatingControl Disabled { get; }
        
        /// <summary>
        /// Set the fractional rates. Indicates the number of equal parts that make up a whole symbol.
        /// </summary>
        IRatingControl Fractions(int fraction);

        /// <summary>
        /// Set the desired range (default start is 0 and end is 5).
        /// </summary>
        IRatingControl Start(int start);

        /// <summary>
        /// Set the desired range (default start is 0 and end is 5).
        /// </summary>
        IRatingControl Stop(int stop);

        /// <summary>
        /// Set the stepping increments used between start and stop.
        /// </summary>
        IRatingControl Step(int step);

        /// <summary>
        /// Set the desired icons to be used in the control.
        /// </summary>
        IRatingControl Symbols(string filledSymbols, string emptySymbols);
    }
}
