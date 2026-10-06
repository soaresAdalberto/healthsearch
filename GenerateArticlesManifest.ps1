$projectRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
$articlesFolder = Join-Path $projectRoot 'wwwroot/articles'
$outFile = Join-Path $projectRoot 'wwwroot/articles-manifest.json'

if (-not (Test-Path -Path $articlesFolder)) {
    Set-Content -Path $outFile -Value '[]' -Encoding UTF8
    exit 0
}

$files = Get-ChildItem -Path $articlesFolder -Filter *.pdf | Sort-Object Name

$items = foreach ($file in $files) {
    '{ "path": "articles/' + $file.Name + '" }'
}

$content = '[' + (($items -join ', ')) + ']'
Set-Content -Path $outFile -Value $content -Encoding UTF8
