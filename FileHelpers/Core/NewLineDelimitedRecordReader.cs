using System.IO;

namespace FileHelpers
{
    /// <summary>
    /// Read a record that is delimited by a newline
    /// </summary>
    internal sealed class NewLineDelimitedRecordReader : IRecordReader
    {
        private readonly TextReader reader;

        /// <summary>
        /// Read a file line by line from the specified textreader
        /// </summary>
        /// <param name="reader">TextReader to read and process</param>
        public NewLineDelimitedRecordReader(TextReader reader)
        {
            this.reader = reader;
        }

        /// <summary>
        /// Read a record from the file
        /// </summary>
        /// <returns>unprocessed record</returns>
        public string ReadRecordString()
        {
            return reader.ReadLine();
        }

        /// <summary>
        /// Close the reader
        /// </summary>
        public void Close()
        {
            reader.Close();
        }
    }
}
