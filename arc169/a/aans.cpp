void slv(){
	int n;cin>>n;
	vi a=readvi(n);
	vi p(n,-1);
	rng(i,1,n)p[i]=read()-1;
	
	vi dep(n);
	rng(i,1,n)dep[i]=dep[p[i]]+1;
	vi sum(n);
	rep(i,n)sum[dep[i]]+=a[i];
	per(i,n){
		if(sum[i]<0)return print('-');
		else if(sum[i]>0) return print('+');
	}
	return print(0);
}