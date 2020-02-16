# $headers=@{}
# $headers.Add("x-rapidapi-host", "deezerdevs-deezer.p.rapidapi.com")
# $headers.Add("x-rapidapi-key", "9df5865a80msh8eb11f35115ec57p1af4e4jsn60182eec8a44")
# $response = Invoke-RestMethod -Uri 'https://deezerdevs-deezer.p.rapidapi.com/search?q=eminem' -Method GET -Headers $headers
# $response | ConvertTo-Json > artista.json

$list = "212377","100323","12047960","54101842","86511","301752","304193","75621062","103798792","105974222","58574292"
$path = "C:\Users\cnaranjo\TODO\02-github\ProgramacionCSharp\MusicApp\albums\"
function Download-Album {
    param (
        $id_album,
        $path
    )
    $headers=@{}
    $headers.Add("x-rapidapi-host", "deezerdevs-deezer.p.rapidapi.com")
    $headers.Add("x-rapidapi-key", "9df5865a80msh8eb11f35115ec57p1af4e4jsn60182eec8a44")
    $response = Invoke-RestMethod -Uri "https://deezerdevs-deezer.p.rapidapi.com/album/$id_album" -Method GET -Headers $headers
    
    #Creacion del directorio
    New-Item $response.title -itemtype Directory -Force
    #Directorio de salida
    $output = "$($response.title)\"
    New-Item "$output\previews" -itemtype Directory -Force
    ################################################################################
    # Toda la información
    $response | ConvertTo-Json > "$output$($response.title).json"
    # Solo una parte de la info
    # $response | Select-Object -Property id,title,release_date | ConvertTo-Json > "$($output)$($response.title).json"
    ################################################################################
    # Generos del album
    $response.genres.data | ConvertTo-Json > "$($output)genres_$($response.title).json"
    # Imagen del album
    Invoke-WebRequest -Uri $response.cover_small -OutFile "$output$($response.title).jpg"
    # Canciones del album
    Invoke-WebRequest -Uri $response.tracklist -OutFile "$($output)canciones_$($response.title).json" 
    
    $canciones = $response.tracks.data | Select-Object -Property title,preview
    $canciones | % {
        Invoke-WebRequest -Uri $_.preview -OutFile "$($output)\previews\$($_.title).mp3" 
    }
}

$list | % { Download-Album $_ $path}