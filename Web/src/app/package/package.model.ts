export class Package {
  name: string = '';
  mode: string = '';
  rate: string = '';
  description: string = '';

  constructor(name, mode, rate, description) {
    this.name = name;
    this.mode = mode;
    this.rate = rate;
    this.description = description;
  }
}
