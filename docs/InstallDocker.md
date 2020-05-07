# Docker

## Install Docker

Steps to install docker:
```text
sudo apt-get update
sudo apt-get upgrade
curl -fsSl https://get.docker.com -o get-docker.sh
sudo sh get-docker.sh
```

## Add your user to docker group

To view the groups your account is in:
```text
groups
```

Add your user to the docker group
```text
sudo usermod -aG docker [user_name]
```

Log off and log back into have the change take affect. To verify type groups again.

## Test docker

```text
Test out docker
docker version
docker info
docker run hello-world
```

## Update docker at a later date

To later upgrade docker just do
```text
sudo apt-get upgrade
```