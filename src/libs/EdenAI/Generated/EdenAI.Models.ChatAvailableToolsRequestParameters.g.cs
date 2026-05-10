
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// The tool's parameters are specified using a JSON Schema object. Detailed format documentation is available in the [JSON Schema reference](https://json-schema.org/understanding-json-schema/).<br/>
    /// **Make sure to well describe each parameter for best results.**<br/>
    /// Example for a weather tool:<br/>
    ///     {<br/>
    ///       "type": "object",<br/>
    ///       "properties": {<br/>
    ///         "location": {<br/>
    ///           "type": "string"<br/>
    ///           "description": "The geographical location for which weather data is requested."<br/>
    ///         },<br/>
    ///         "unit": {<br/>
    ///           "type": "string", "enum": ["Celsius", "Fahrenheit"]<br/>
    ///           "description": "The unit of measurement for temperature."<br/>
    ///         }<br/>
    ///       },<br/>
    ///       "required": ["location"]<br/>
    ///     }<br/>
    ///     
    /// </summary>
    public sealed partial class ChatAvailableToolsRequestParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}