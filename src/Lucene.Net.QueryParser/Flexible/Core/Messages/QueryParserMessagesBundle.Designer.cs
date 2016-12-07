﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lucene.Net.QueryParsers.Flexible.Core.Messages {
    using System;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class QueryParserMessagesBundle {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QueryParserMessagesBundle() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lucene.Net.QueryParsers.Flexible.Core.Messages.QueryParserMessagesBundle", typeof(QueryParserMessagesBundle).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse text &quot;{0}&quot; using {1}.
        /// </summary>
        internal static string COULD_NOT_PARSE_NUMBER {
            get {
                return ResourceManager.GetString("COULD_NOT_PARSE_NUMBER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string EMPTY_MESSAGE {
            get {
                return ResourceManager.GetString("EMPTY_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error: {0}.
        /// </summary>
        internal static string INVALID_SYNTAX {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error, cannot parse {0}: {1}.
        /// </summary>
        internal static string INVALID_SYNTAX_CANNOT_PARSE {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_CANNOT_PARSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Term can not end with escape character..
        /// </summary>
        internal static string INVALID_SYNTAX_ESCAPE_CHARACTER {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_ESCAPE_CHARACTER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-hex character in Unicode escape sequence: {0}.
        /// </summary>
        internal static string INVALID_SYNTAX_ESCAPE_NONE_HEX_UNICODE {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_ESCAPE_NONE_HEX_UNICODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Truncated unicode escape sequence..
        /// </summary>
        internal static string INVALID_SYNTAX_ESCAPE_UNICODE_TRUNCATION {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_ESCAPE_UNICODE_TRUNCATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fractional edit distances are not allowed..
        /// </summary>
        internal static string INVALID_SYNTAX_FUZZY_EDITS {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_FUZZY_EDITS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The similarity value for a fuzzy search must be between 0.0 and 1.0..
        /// </summary>
        internal static string INVALID_SYNTAX_FUZZY_LIMITS {
            get {
                return ResourceManager.GetString("INVALID_SYNTAX_FUZZY_LIMITS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Leading wildcard is not allowed: {0}.
        /// </summary>
        internal static string LEADING_WILDCARD_NOT_ALLOWED {
            get {
                return ResourceManager.GetString("LEADING_WILDCARD_NOT_ALLOWED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert query to lucene syntax: {0} error: {1}.
        /// </summary>
        internal static string LUCENE_QUERY_CONVERSION_ERROR {
            get {
                return ResourceManager.GetString("LUCENE_QUERY_CONVERSION_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This node does not support this action..
        /// </summary>
        internal static string NODE_ACTION_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("NODE_ACTION_NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number class not supported by NumericRangeQueryNode: {0}.
        /// </summary>
        internal static string NUMBER_CLASS_NOT_SUPPORTED_BY_NUMERIC_RANGE_QUERY {
            get {
                return ResourceManager.GetString("NUMBER_CLASS_NOT_SUPPORTED_BY_NUMERIC_RANGE_QUERY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &quot;{0}&quot; is numeric and cannot have an empty value..
        /// </summary>
        internal static string NUMERIC_CANNOT_BE_EMPTY {
            get {
                return ResourceManager.GetString("NUMERIC_CANNOT_BE_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {1} with value {0} not supported..
        /// </summary>
        internal static string PARAMETER_VALUE_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("PARAMETER_VALUE_NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many boolean clauses, the maximum supported is {0}: {1}.
        /// </summary>
        internal static string TOO_MANY_BOOLEAN_CLAUSES {
            get {
                return ResourceManager.GetString("TOO_MANY_BOOLEAN_CLAUSES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported NumericField.DataType: {0}.
        /// </summary>
        internal static string UNSUPPORTED_NUMERIC_DATA_TYPE {
            get {
                return ResourceManager.GetString("UNSUPPORTED_NUMERIC_DATA_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wildcard is not supported for query: {0}.
        /// </summary>
        internal static string WILDCARD_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("WILDCARD_NOT_SUPPORTED", resourceCulture);
            }
        }
    }
}
