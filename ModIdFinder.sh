#!/bin/bash

find . -type f -name "*.sbmi" >> ./allModDatas.txt

MODIDARR=()

while read path; do
  while read sbmiLine; do
      if [[ $sbmiLine = \<Id\>* ]] ; then
          tmp=${sbmiLine#*>}
          modId=${tmp%<*}
          modPath=${path%/*}
          MODIDARR+=(\{\"value\":$modId,\"path\":\"$modPath\"\})
      fi
  done < "$path"
done < allModDatas.txt

data_string="${MODIDARR[*]}"
echo "matrix={\"include\":[${data_string//${IFS:0:1}/,}]}]"
