sudo apt update
sudo apt install -y python3 python3-pip
sudo apt install -y nodejs npm
pip3 install --upgrade pip
pip3 install online-judge-tools --break-system-packages
sudo npm install -g n
sudo n stable
sudo apt purge -y nodejs npm
sudo npm install -g atcoder-cli
echo "alias oj-t-fs='oj t -c \"dotnet fsi Program.fsx\" -d ./tests/'" >> ~/.bashrc
echo "alias acc-s-fs='acc submit Program.fsx -- -l 5021'" >> ~/.bashrc
exec bash