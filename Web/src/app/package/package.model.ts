export class Package {
  id: string = '';
  name: string = '';
  mode: string = '';
  rate: string = '';
  description: string = '';
  accessClaim: string = '';

  constructor(name, mode, rate, description) {
    this.name = name;
    this.mode = mode;
    this.rate = rate;
    this.description = description;
  }
}
