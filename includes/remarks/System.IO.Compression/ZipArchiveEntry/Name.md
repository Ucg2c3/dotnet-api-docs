The <xref:System.IO.Compression.ZipArchiveEntry.Name%2A> property contains the portion of the <xref:System.IO.Compression.ZipArchiveEntry.FullName%2A> property that follows the final directory separator character (\\), and does not include the subdirectory hierarchy. For example, if you create two entries in a zip archive by using the <xref:System.IO.Compression.ZipFileExtensions.CreateEntryFromFile%2A> method and provide `NewEntry.txt` as the name for the first entry and `AddedFolder\\NewEntry.txt` for the second entry, both entries will have `NewEntry.txt` in the <xref:System.IO.Compression.ZipArchiveEntry.Name%2A> property. The first entry will also have `NewEntry.txt` in the <xref:System.IO.Compression.ZipArchiveEntry.FullName%2A> property, but the second entry will have `AddedFolder\\NewEntry.txt` in the <xref:System.IO.Compression.ZipArchiveEntry.FullName%2A> property.

## Examples

The following example shows how to retrieve entries from a zip archive and evaluate the properties of the entries. It uses the <xref:System.IO.Compression.ZipArchiveEntry.Name%2A> property to display the name of the entry, and the <xref:System.IO.Compression.ZipArchiveEntry.Length%2A> and <xref:System.IO.Compression.ZipArchiveEntry.CompressedLength%2A> properties to calculate how much the file was compressed.

:::code language="csharp" source="~/snippets/csharp/System.IO.Compression/ZipArchive/GetEntry/program1.cs" id="Snippet1":::
:::code language="vb" source="~/snippets/visualbasic/System.IO.Compression/ZipArchive/GetEntry/program1.vb" id="Snippet1":::
