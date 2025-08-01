The <xref:System.IO.Compression.ZipFileExtensions> class contains only static methods that extend the <xref:System.IO.Compression.ZipArchive> and <xref:System.IO.Compression.ZipArchiveEntry> classes. You do not create an instance of the <xref:System.IO.Compression.ZipFileExtensions> class; instead, you use these methods from instances of <xref:System.IO.Compression.ZipArchive> or <xref:System.IO.Compression.ZipArchiveEntry>.

To use the extension methods, you must reference the `System.IO.Compression.FileSystem` assembly in your project. The `System.IO.Compression.FileSystem` assembly is not available in Windows 8.x Store apps. Therefore, the <xref:System.IO.Compression.ZipFileExtensions> and <xref:System.IO.Compression.ZipFile> classes (both of which are in the `System.IO.Compression.FileSystem` assembly) are not available in Windows 8.x Store apps. In Windows 8.x Store apps, you work with compressed files by using the methods in <xref:System.IO.Compression.ZipArchive>, <xref:System.IO.Compression.ZipArchiveEntry>, <xref:System.IO.Compression.DeflateStream>, and <xref:System.IO.Compression.GZipStream>.

The <xref:System.IO.Compression.ZipFileExtensions> class contains four methods that extend <xref:System.IO.Compression.ZipArchive>:

-   <xref:System.IO.Compression.ZipFileExtensions.CreateEntryFromFile%28System.IO.Compression.ZipArchive%2CSystem.String%2CSystem.String%29>

-   <xref:System.IO.Compression.ZipFileExtensions.CreateEntryFromFile%28System.IO.Compression.ZipArchive%2CSystem.String%2CSystem.String%2CSystem.IO.Compression.CompressionLevel%29>

-   <xref:System.IO.Compression.ZipFileExtensions.ExtractToDirectory%28System.IO.Compression.ZipArchive%2CSystem.String%29>

-   <xref:System.IO.Compression.ZipFileExtensions.ExtractToDirectory%28System.IO.Compression.ZipArchive%2CSystem.String%2CSystem.Boolean%29>

The <xref:System.IO.Compression.ZipFileExtensions> class contains two methods that extend <xref:System.IO.Compression.ZipArchiveEntry>:

-   <xref:System.IO.Compression.ZipFileExtensions.ExtractToFile%28System.IO.Compression.ZipArchiveEntry%2CSystem.String%29>

-   <xref:System.IO.Compression.ZipFileExtensions.ExtractToFile%28System.IO.Compression.ZipArchiveEntry%2CSystem.String%2CSystem.Boolean%29>

## Examples

The following example shows how to create a new entry in a zip archive from an existing file, and extract the contents of the archive to a directory.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/Entries/program3.cs" id="Snippet3":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/Entries/program3.vb" id="Snippet3":::

The following example shows how to iterate through the contents of a zip archive and extract files that have a .txt extension.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/Entries/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/Entries/program1.vb" id="Snippet1":::
