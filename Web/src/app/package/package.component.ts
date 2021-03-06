import { Component } from '@angular/core';
import { Package} from './package.model';
import { AuthService } from '../auth/auth.service';
import { AppUserAuth } from '../auth/app-user-auth.model';
import { PackageService } from './package.service';

@Component({
  templateUrl: './package.component.html',
  styleUrls: ['./package.component.css']
})
export class PackageComponent {
  packages: Package[] = [];
  securityObject: AppUserAuth = null;

  constructor(private authService: AuthService, private packageService: PackageService) {
    this.securityObject = authService.securityObject;

    this.packageService.getPackages()
      .subscribe(packages => this.packages = packages);

    console.log(this.packages);

    //this.productService.getProducts()
    //  .subscribe(products => this.products = products);

    // this.packages = [
    //   new Package('Channel 1', 'Premimum', '$150', 'Channel 1 description'),
    //   new Package('Channel 2', 'Standard', '$90', 'Channel 2 description'),
    //   new Package('Channel 3', 'Free', '$$0', 'Channel 3 description'),
    //   new Package('Channel 4', 'Premimum', '$170', 'Channel 4 description')
    // ];
    console.log(this.packages);
  }

  logout(): void {
    this.authService.logout();
  }

  enrollPackage(name: string) {
    return true;
  }

}
