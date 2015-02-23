using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace BootstrapRating.Support
{
    /// <exclude/>
    internal static class Extensions
    {
        /// <exclude/>
        public static string ToStringLower(this object value)
        {
            return value != null ? value.ToString().ToLower() : null;
        }
    }
}



