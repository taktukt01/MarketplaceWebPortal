for %%G in (*.sql) do sqlcmd /S (localdb)\ProjectV13 /d MarketplaceWebPortal -E -i"%%G"
pause