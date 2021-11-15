using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserSetField
{
    public class MoodAnalyserFactoryReflection
    {
        /// <summary>
        /// Reflection UC5 using parameter constructor
        /// Creates the mood analyser parameter object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructor">The constructor.</param>
        /// <param name="message">The message.</param>

        public object CreateMoodAnalyserParameterObject(string className, string constructor, string message)
        {
            try
            {
                Type tyep = typeof(MoodAnalyser);
                if (tyep.Name.Equals(className) || tyep.FullName.Equals(className))
                {
                    if (tyep.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = tyep.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.Class_Not_Found, "class not found");

                }


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Invokes the analyser method.
        /// UC6
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyzarProblem.CustomException">method not found</exception>
        public string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyserFactoryReflection factory = new MoodAnalyserFactoryReflection();
                object moodAnalyserObject = factory.CreateMoodAnalyserParameterObject("MoodAnalyzarProblem.ModeAnalyzer", "ModeAnalyzer", message);
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();
            }
            catch (NullReferenceException )
            {
                throw new CustomException(CustomException.ExceptionType.No_Such_Method, "method not found");
            }
        }

        /// <summary>
        /// Sets the field.
        /// UC7
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyzarProblem.CustomException">
        /// message should not be null
        /// or
        /// fieldNmae should not be null
        /// </exception>
        /// <exception cref="System.Exception"></exception>
        public string SetField(string msg, string fieldName)
        {
            try
            {
                MoodAnalyserFactoryReflection factory = new MoodAnalyserFactoryReflection();
                MoodAnalyser obj = (MoodAnalyser)factory.createMoodAnalyserObject("MoodAnalyserSetField.MoodAnalyser", "MoodAnalyser");
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (field != null)
                {
                    if (msg != null)
                    {
                        throw new CustomException(CustomException.ExceptionType.Null_Message, "message should not be null");

                    }
                    field.SetValue(obj, msg);
                    return obj.message;
                }
                throw new CustomException(CustomException.ExceptionType.Field_Null, "fieldNmae should not be null");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private MoodAnalyser createMoodAnalyserObject(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
