A zip archive contains an entry for each compressed file. The <xref:System.IO.Compression.ZipArchiveEntry> class enables you to examine the properties of an entry, and open or delete the entry. When you open an entry, you can modify the compressed file by writing to the stream for that compressed file.

The methods for manipulating zip archives and their file entries are spread across three classes: <xref:System.IO.Compression.ZipFile>, <xref:System.IO.Compression.ZipArchive> and <xref:System.IO.Compression.ZipArchiveEntry>.

|To...|Use...|
|---------|----------|
|Create a zip archive from a directory|<xref:System.IO.Compression.ZipFile.CreateFromDirectory%2A?displayProperty=nameWithType>|
|Extract the contents of a zip archive to a directory|<xref:System.IO.Compression.ZipFile.ExtractToDirectory%2A?displayProperty=nameWithType>|
|Add new files to an existing zip archive|<xref:System.IO.Compression.ZipArchive.CreateEntry%2A?displayProperty=nameWithType>|
|Retrieve a file in a zip archive|<xref:System.IO.Compression.ZipArchive.GetEntry%2A?displayProperty=nameWithType>|
|Retrieve all of the files in a zip archive|<xref:System.IO.Compression.ZipArchive.Entries%2A?displayProperty=nameWithType>|
|To open a stream to an individual file contained in a zip archive|<xref:System.IO.Compression.ZipArchiveEntry.Open%2A?displayProperty=nameWithType>|
|Delete a file from a zip archive|<xref:System.IO.Compression.ZipArchiveEntry.Delete%2A?displayProperty=nameWithType>|

If you reference the `System.IO.Compression.FileSystem` assembly in your project, you can access two extension methods for the <xref:System.IO.Compression.ZipArchiveEntry> class. Those methods are <xref:System.IO.Compression.ZipFileExtensions.ExtractToFile%28System.IO.Compression.ZipArchiveEntry%2CSystem.String%29> and <xref:System.IO.Compression.ZipFileExtensions.ExtractToFile%28System.IO.Compression.ZipArchiveEntry%2CSystem.String%2CSystem.Boolean%29>, and they enable you to decompress the contents of the entry to a file. The `System.IO.Compression.FileSystem` assembly is not available in Windows 8. In Windows 8.x Store apps, you can decompress the contents of an archive by using <xref:System.IO.Compression.DeflateStream> or <xref:System.IO.Compression.GZipStream>, or you can use the Windows Runtime types <xref:Windows.Storage.Compression.Compressor> and <xref:Windows.Storage.Compression.Decompressor> to compress and decompress files.

## Examples

The first example shows how to create a new entry in a zip archive and write to it.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/CreateEntry/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/CreateEntry/program1.vb" id="Snippet1":::

The second example shows how to use the <xref:System.IO.Compression.ZipFileExtensions.ExtractToFile%28System.IO.Compression.ZipArchiveEntry%2CSystem.String%29> extension method. You must reference the `System.IO.Compression.FileSystem` assembly in your project for the code to execute.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/Entries/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/Entries/program1.vb" id="Snippet1":::
