using System;
using System.Collections.Generic;
using System.Text;

namespace Hashes
{
    class Class1
    {
    }
}







//using System;

//namespace BLL
//{
//    public class CustomMessage
//    {
//        public static Result Error(Exception ex)
//        {
//            var message = ex.Message;

//            if (ex.InnerException != null && ex.InnerException.InnerException != null)
//            {
//                message = ex.InnerException.InnerException.Message;
//            }

//            Logger.Error(ex.ToString());
//            return Error(message ?? "");
//        }

//        public static Result Error(string message)
//        {
//            var result = new Result
//            {
//                Success = false,
//                DisplayMessage = message
//            };

//            return result;
//        }

//        public static Result Success(string message)
//        {
//            var result = new Result
//            {
//                Success = true,
//                DisplayMessage = message
//            };

//            return result;
//        }
//    }
//}





//namespace Model
//{
//    public class Result
//    {
//        public bool Success { get; set; }
//        public string DisplayMessage { get; set; }
//        public string Value { get; set; }
//    }

//    public class Result<T>
//    {
//        public bool Success { get; set; }
//        public string DisplayMessage { get; set; }
//        public T Value { get; set; }
//    }
//}




//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System;
//using System.Collections.Generic;

//namespace DAL
//{
//    public class JsonHelper
//    {
//        /// <summary>
//        /// JSON Serialization
//        /// </summary>
//        public static string JsonSerialize(object obj)
//        {
//            var jsonString = JsonConvert.SerializeObject(obj);

//            return jsonString;
//        }

//        /// <summary>
//        /// JSON Deserialization with ignoring specified property name.
//        /// </summary>
//        public static T JsonDeserialize<T>(object obj, List<string> ignorePropertyNames)
//        {
//            var jsonResolver = new IgnorePropertyContractResolver(ignorePropertyNames);

//            var serializerSettings = new JsonSerializerSettings
//            {
//                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
//                NullValueHandling = NullValueHandling.Ignore,
//                ContractResolver = jsonResolver
//            };

//            var jsonString = JsonConvert.SerializeObject(obj, serializerSettings);

//            return JsonDeserialize<T>(jsonString);
//        }

//        /// <summary>
//        /// JSON Deserialization
//        /// </summary>
//        public static T JsonDeserialize<T>(object obj)
//        {
//            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
//            {
//                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
//            });

//            return JsonDeserialize<T>(jsonString);
//        }

//        /// <summary>
//        /// JSON Deserialization
//        /// </summary>
//        public static T JsonDeserialize<T>(string jsonString)
//        {
//            if (string.IsNullOrWhiteSpace(jsonString))
//            {
//                throw new ArgumentException($"JSON Deserialize Error: Parameter cannot be null");
//            }

//            T obj = JsonConvert.DeserializeObject<T>(jsonString);

//            return obj;
//        }

//        public static List<string> JsonFindSpecifyElement(string jsonString, string value)
//        {
//            JObject jObject = JObject.Parse(jsonString);
//            List<string> values = new List<string>();
//            foreach (var member in jObject["Value"])
//            {
//                if (!values.Contains(member[value].ToString()))
//                    values.Add(member[value].ToString());
//            }

//            return values;
//        }
//    }
//}
