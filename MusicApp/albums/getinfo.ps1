# ID de los albums
$list = 
"212377","100323","12047960","54101842","86511","301752",
"304193","75621062","103798792","105974222","58574292",
"53522522","78629152","9410156","259463","1434890","40584351",
"356130","390984","94996382","45409451","95105092"

function Get-Album {
    param (
        $id_album
    )
    # Hacemos la petición con el id del album
    $headers=@{}
    $headers.Add("x-rapidapi-host", "deezerdevs-deezer.p.rapidapi.com")
    $headers.Add("x-rapidapi-key", "9df5865a80msh8eb11f35115ec57p1af4e4jsn60182eec8a44")
    $response = Invoke-RestMethod -Uri "https://deezerdevs-deezer.p.rapidapi.com/album/$id_album" -Method GET -Headers $headers
    # echo $($response | gm)
    return $response

}

Function GetAlbum-Image{
    param(
        $album
    )
    $albumartistname = $($album.artist.name) -replace '\?|\\|:|/|"|\[|\]|\*|<|>|\|',''
    $albumtitle = $($album.title) -replace '\?|\\|:|/|"|\[|\]|\*|<|>|\|',''
    New-Item "images\$($albumtitle)"  -itemtype Directory -Force
    New-Item "previews\$($albumtitle)"  -itemtype Directory -Force
    New-Item "info\$($albumtitle)"  -itemtype Directory -Force

    Invoke-WebRequest -Uri $album.cover_small -OutFile "images\$($albumtitle)\$($albumtitle).jpg"
    # Canciones del album
    # Invoke-WebRequest -Uri $album.tracklist -OutFile "$($output)canciones_$($albumtitle).json" 
    
    $canciones = $album.tracks.data #| Select-Object -Property title,preview
    $canciones | % {
        $canciones | ConvertTo-Json > "info\$($albumtitle)\$($title).json"
        $title = $($_.title) -replace '\?|\\|:|/|"|\[|\]|\*|<|>|\|',''
        echo $title
        Invoke-WebRequest -Uri $_.preview -OutFile "previews\$($albumtitle)\$($title).mp3" 
    }

}

# Llenamos una lista de objetos de tipo album
$albums=@()
$list | % {
    GetAlbum-Image $(Get-Album $_)
    $albums += $(Get-Album $_)
}
$albums | ConvertTo-Json > "albums.json"