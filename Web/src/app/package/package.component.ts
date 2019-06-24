import { Component } from '@angular/core';
import { Package} from './package.model';

@Component({
  templateUrl: './package.component.html',
  styleUrls: ['./package.component.css']
})
export class PackageComponent {
  packages: Package[] = [];
  constructor() {
    this.packages = [
      new Package('Channel 1', 'Premimum', '$150', 'Channel 1 description'),
      new Package('Channel 2', 'Standard', '$90', 'Channel 2 description'),
      new Package('Channel 3', 'Free', '$$0', 'Channel 3 description'),
      new Package('Channel 4', 'Premimum', '$170', 'Channel 4 description')
    ];
    console.log(this.packages);
  }
}
