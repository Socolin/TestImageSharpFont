using System.Text;

namespace ImageSharpFontBrowserComparator;

public class HtmlTestOutput(int fontSize)
{
	private List<FontDefinition> _fonts = [];
	private List<TestDefinition> _tests = [];

	public void AddTest(string name, string imagePath, string text, string fontPath)
	{
		var fontName = CreateRandomHex();
		_fonts.Add(new FontDefinition(fontName, fontPath));
		_tests.Add(new TestDefinition(name, imagePath, fontName, text));
	}

	private static string CreateRandomHex()
	{
		var buffer = new byte[4];
		Random.Shared.NextBytes(buffer);
		return Convert.ToHexStringLower(buffer);
	}

	public void Save(string path)
	{
		var fontBlock = new StringBuilder();
		foreach (var fontDefinition in _fonts)
		{
			fontBlock.AppendLine($$"""
			                       @font-face
			                       {
			                           font-family: '{{fontDefinition.Name}}';
			                           src: url('{{fontDefinition.Path}}') format('truetype');
			                       }
			                       """
			);
		}

		var testBlock = new StringBuilder();
		foreach (var testDefinition in _tests)
		{
			// language=HTML
			testBlock.AppendLine($$"""
			                       <h3>{{testDefinition.Name}}</h3>
			                       <div class="test">
			                           <div class="render chrome-render">
			                               <div>Chrome: </div>
			                               <div class="text" style="font-family: '{{testDefinition.FontName}}', 'Adobe NotDef'">{{testDefinition.Text}}</div>
			                           </div>
			                           <div class="render image-sharp-render">
			                               <div>ImageSharp: </div>
			                               <img src="{{testDefinition.Image}}" alt="">
			                           </div>
			                           <div class="render overlap-render">
			                               <div>Overlap: </div>
			                               <div class="overlap" style="background-image: url('{{testDefinition.Image}}')">
			                                   <div class="text" style="font-family: '{{testDefinition.FontName}}', 'Adobe NotDef'">{{testDefinition.Text}}</div>
			                               </div>
			                           </div>
			                       </div>
			                       """
			);
		}

		var sb = new StringBuilder();


		// language=HTML
		sb.Append($$"""
		            <!DOCTYPE html>
		            <html lang="en">
		            <head>
		                <meta charset="UTF-8">
		                <meta name="viewport" content="width=device-width, initial-scale=1.0">
		                <title>Test</title>
		                <style>
		                    @font-face {
		                        font-family: 'Adobe NotDef';
		                        src: url('Fonts/AND-Regular.otf') format('opentype');
		                    }

		                    {{fontBlock}}

		                    body {
		                        margin: 0;
		                        padding: 20px;
		                    }
		                    
		                    .text {
		                        font-size: {{fontSize}}px;
		                    }
		                    
		                    .overlap {
		                        background-repeat: no-repeat;
		                    }
		                    
		                    .render  {
		                        display: grid;
		                        grid-template-columns: 120px 1fr;
		                        align-items: center;
		                    }

		                </style>
		            </head>
		            <body>
		            {{testBlock}}
		            </body>
		            </html>

		            """
		);

		File.WriteAllText(path, sb.ToString());
	}
}

public record FontDefinition(string Name, string Path);

public record TestDefinition(string Name, string Image, string FontName, string Text);
