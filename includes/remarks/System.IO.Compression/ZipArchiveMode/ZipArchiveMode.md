When you set the mode to Read, the underlying file or stream must support reading, but does not have to support seeking. If the underlying file or stream supports seeking, the files are read from the archive as they are requested. If the underlying file or stream does not support seeking, the entire archive is held in memory.

When you set the mode to Create, the underlying file or stream must support writing, but does not have to support seeking. Each entry in the archive can be opened only once for writing. If you create a single entry, the data is written to the underlying stream or file as soon as it is available. If you create multiple entries, such as by calling the <xref:System.IO.Compression.ZipFile.CreateFromDirectory%2A> method, the data is written to the underlying stream or file after all the entries are created.

When you set the mode to Update, the underlying file or stream must support reading, writing, and seeking. The content of the entire archive is held in memory, and no data is written to the underlying file or stream until the archive is disposed.

The following methods include a parameter named `mode` that lets you specify the archive mode:

- <xref:System.IO.Compression.ZipArchive.%23ctor%28System.IO.Stream%2CSystem.IO.Compression.ZipArchiveMode%2CSystem.Boolean%29?displayProperty=nameWithType>

- <xref:System.IO.Compression.ZipArchive.%23ctor%28System.IO.Stream%2CSystem.IO.Compression.ZipArchiveMode%29?displayProperty=nameWithType>

- <xref:System.IO.Compression.ZipFile.Open%28System.String%2CSystem.IO.Compression.ZipArchiveMode%29?displayProperty=nameWithType>

## Examples

The following example shows how to specify a `ZipArchiveMode` value when creating a <xref:System.IO.Compression.ZipArchive> object.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/CreateEntry/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/CreateEntry/program1.vb" id="Snippet1":::
