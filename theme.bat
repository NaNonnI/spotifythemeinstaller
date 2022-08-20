@echo off
cls
echo Backup de Spotify 2/6
spicetify backup apply
echo Injection de l'extention 3/6
spicetify config extensions dribbblish.js
echo Configuration de l'extention 4/6
spicetify config current_theme dribbblish color_scheme dracula
echo Injection du theme 5/6
spicetify config inject_css 1 replace_colors 1 overwrite_assets 1
echo Application du theme 6/6
spicetify apply
echo Done !
sleep 10