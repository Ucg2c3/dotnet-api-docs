> [!NOTE]
> To use the <xref:System.IO.Compression.ZipFile> class in a .NET Framework app, you must add a reference to the `System.IO.Compression.FileSystem` assembly in your project. For information on how to add a reference to your project in Visual Studio, see [How to: Add or Remove References](/visualstudio/ide/how-to-add-or-remove-references-by-using-the-reference-manager).

The methods for manipulating zip archives and their files are spread across three classes: <xref:System.IO.Compression.ZipFile>, <xref:System.IO.Compression.ZipArchive>, and <xref:System.IO.Compression.ZipArchiveEntry>.

| To...                                 | Use... |
|---------------------------------------|--------|
| Create a zip archive from a directory | <xref:System.IO.Compression.ZipFile.CreateFromDirectory%2A?displayProperty=nameWithType> |
| Extract the contents of a zip archive to a directory | <xref:System.IO.Compression.ZipFile.ExtractToDirectory%2A?displayProperty=nameWithType> |
| Add new files to an existing zip archive | <xref:System.IO.Compression.ZipArchive.CreateEntry%2A?displayProperty=nameWithType> |
| Retrieve a file in a zip archive      | <xref:System.IO.Compression.ZipArchive.GetEntry%2A?displayProperty=nameWithType> |
| Retrieve all of the files in a zip archive | <xref:System.IO.Compression.ZipArchive.Entries%2A?displayProperty=nameWithType> |
| Open a stream to an individual file contained in a zip archive|<xref:System.IO.Compression.ZipArchiveEntry.Open%2A?displayProperty=nameWithType> |
| Delete a file from a zip archive      | <xref:System.IO.Compression.ZipArchiveEntry.Delete%2A?displayProperty=nameWithType> |

## Examples

This example shows how to create and extract a zip archive by using the <xref:System.IO.Compression.ZipFile> class. It compresses the contents of a folder into a zip archive, and then extracts that content to a new folder.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipFile/CreateFromDirectory/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipFile/CreateFromDirectory/program1.vb" id="Snippet1":::
